using AMcore.Core;
using AMcore.Models;
using AMcore.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AlphaUTMMon.Forms
{
    public partial class MainForm : Form
    {
        private readonly BL _bl;
        private CancellationTokenSource _tokenSource = new();

        public MainForm(BL bl)
        {
            InitializeComponent();
            DataGrid.MouseDown += DataGrid_MouseDown; ;

            _bl = bl;
            utmParamsBindingSource.DataSource = _bl.UtmParams;
        }

        private void DataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Получаем информацию о строке и столбце под курсором
                var hitTestInfo = DataGrid.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0)
                {
                    if (DataGrid.SelectedRows.Count == 1)
                    {

                        // Снимаем выделение со всех строк
                        DataGrid.ClearSelection();
                        // Выделяем строку, по которой щелкнули
                        DataGrid.Rows[hitTestInfo.RowIndex].Selected = true;

                        // Устанавливаем текущую ячейку
                        DataGrid.CurrentCell = DataGrid.Rows[hitTestInfo.RowIndex].Cells[hitTestInfo.ColumnIndex];
                    }

                    // Открываем контекстное меню вручную
                    contextMenuStrip1.Show(DataGrid, e.Location);
                }
            }
        }


        private void TSB_Add_Click(object sender, EventArgs e)
        {
            UtmParam utmParam = new();
            UtmParamForm utmParamForm = new(utmParam);
            utmParamForm.ShowDialog(this);
            if (utmParamForm.DialogResult != DialogResult.OK)
                return;
            _bl.AddUtmParam(utmParam);
        }
        private async void TSB_Refresh_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            toolStripProgressBar1.Maximum = _bl.UtmParams.Count;
            toolStripProgressBar1.Value = 0;
            DataGrid.Cursor = Cursors.WaitCursor;
            await Task.Run(() =>
            {
                try
                {
                    foreach (UtmParam param in _bl.UtmParams)
                    {
                        param.UTMConnectionState = UTMConnectionState.Updating;
                        param.ConnectionStateErrorDetails = "";
                    }
                    RefreshDataTable();
                    _tokenSource = new CancellationTokenSource();
                    Parallel.ForEach(_bl.UtmParams, new ParallelOptions() { MaxDegreeOfParallelism = 20, CancellationToken = _tokenSource.Token }, param =>
                    {
                        Invoke(() => { toolStripProgressBar1.PerformStep(); });
                        BL.GetOrRefreshUtmStateAsync(param).Wait();
                    });
                }
                catch (OperationCanceledException)
                {
                    MessageBox.Show("Обновление отменено.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    RefreshDataTable();
                    _tokenSource.Dispose();
                }
            });
            statusStrip1.Visible = false;
        }

        private void RefreshDataTable()
        {
            Invoke(() =>
            {
                foreach (DataGridViewRow row in DataGrid.Rows)
                {
                    switch ((row.DataBoundItem as UtmParam)?.UTMConnectionState)
                    {
                        case UTMConnectionState.NotAvailable:
                            row.Cells["DescriptionConnectionStateColumn"].Style.BackColor = Color.Red;
                            break;
                        case UTMConnectionState.Established:
                            row.Cells["DescriptionConnectionStateColumn"].Style.BackColor = Color.Lime;
                            break;
                    }
                }
                DataGrid.Cursor = Cursors.Arrow;
                DataGrid.Refresh();
            });

        }

        private void TSBIStopUpdateStop_ButtonClick(object sender, EventArgs e)
        {
            _tokenSource?.Cancel();
        }

        private void TsmiConnect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGrid.SelectedRows)
            {
                if (row?.DataBoundItem is UtmParam param)
                {
                    string puttyPath = @"C:\Program Files\PuTTY\putty.exe"; // Путь к putty.exe
                    string host = param.ConnectionHost;
                    string username = "root";
                    string password = "Rkeeper776417";

                    // Настройка процесса для запуска PuTTY
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = puttyPath,
                        Arguments = $"{username}@{host} -pw {password}",
                        UseShellExecute = false, // Важно для перенаправления ввода/вывода
                        CreateNoWindow = true    // Показать окно PuTTY (можно изменить на true, если не нужно окно)
                    };
                    Process.Start(processInfo);
                }
            }
        }

        private void TsmiOpenVpn_Click(object sender, EventArgs e)
        {
            if (DataGrid.SelectedRows[0]?.DataBoundItem is UtmParam param)
                Process.Start(new ProcessStartInfo
                {
                    FileName = $"http://{param.ConnectionString}",
                    UseShellExecute = true
                });
        }

        private void TsmiPing_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGrid.SelectedRows)
            {
                if (row?.DataBoundItem is UtmParam param)
                {
                    ProcessStartInfo processInfo = new ProcessStartInfo
                    {
                        FileName = "ping",
                        Arguments = $"{param.ConnectionHost} -t",
                        UseShellExecute = false,
                        CreateNoWindow = false // Показать окно консоли
                    };
                    Process.Start(processInfo);
                }
            }
        }
    }
}
