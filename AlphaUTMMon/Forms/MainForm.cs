using AMcore.Core;
using AMcore.Models;
using AMcore.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaUTMMon.Forms
{
    public partial class MainForm : Form
    {
        private readonly BL _bl;
        private CancellationTokenSource _tokenSource = new();

        public MainForm(BL bl)
        {
            InitializeComponent();
            _bl = bl;
            utmParamsBindingSource.DataSource = _bl.UtmParams;
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
                    Parallel.ForEach(_bl.UtmParams, new ParallelOptions() { MaxDegreeOfParallelism = 20, CancellationToken  = _tokenSource.Token }, param =>
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
        private void DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGrid.ClearSelection();
            DataGrid.Rows[e.RowIndex].Selected = true;
        }
    }
}
