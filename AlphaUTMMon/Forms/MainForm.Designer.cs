namespace AlphaUTMMon.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            TSBIStopUpdateStop = new ToolStripSplitButton();
            DataGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Version = new DataGridViewTextBoxColumn();
            ConnectionString = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DescriptionConnectionStateColumn = new DataGridViewTextBoxColumn();
            ConnectionStateErrorDetails = new DataGridViewTextBoxColumn();
            utmParamsBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            TSB_Add = new ToolStripButton();
            TSB_Edit = new ToolStripButton();
            TSB_Refresh = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmiConnect = new ToolStripMenuItem();
            tsmiOpenVpn = new ToolStripMenuItem();
            tsmiPing = new ToolStripMenuItem();
            IncomingDocumentsCount = new DataGridViewTextBoxColumn();
            OutgoingDocumentsCount = new DataGridViewTextBoxColumn();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)utmParamsBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(DataGrid);
            toolStripContainer1.ContentPanel.Size = new Size(800, 425);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1, TSBIStopUpdateStop });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(451, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(166, 17);
            toolStripStatusLabel1.Text = "Обновление состояния УТМ:";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(200, 16);
            toolStripProgressBar1.Step = 1;
            // 
            // TSBIStopUpdateStop
            // 
            TSBIStopUpdateStop.Image = (Image)resources.GetObject("TSBIStopUpdateStop.Image");
            TSBIStopUpdateStop.ImageTransparentColor = Color.Magenta;
            TSBIStopUpdateStop.Name = "TSBIStopUpdateStop";
            TSBIStopUpdateStop.Size = new Size(66, 20);
            TSBIStopUpdateStop.Text = "Стоп";
            TSBIStopUpdateStop.ButtonClick += TSBIStopUpdateStop_ButtonClick;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToOrderColumns = true;
            DataGrid.AllowUserToResizeRows = false;
            DataGrid.AutoGenerateColumns = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Version, ConnectionString, dataGridViewTextBoxColumn2, DescriptionConnectionStateColumn, ConnectionStateErrorDetails, IncomingDocumentsCount, OutgoingDocumentsCount });
            DataGrid.DataSource = utmParamsBindingSource;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.Location = new Point(0, 0);
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowHeadersVisible = false;
            DataGrid.RowTemplate.Height = 25;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(800, 425);
            DataGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "FSRARID";
            dataGridViewTextBoxColumn1.HeaderText = "FSRARID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 151;
            // 
            // Version
            // 
            Version.DataPropertyName = "Version";
            Version.HeaderText = "Version";
            Version.Name = "Version";
            Version.ReadOnly = true;
            // 
            // ConnectionString
            // 
            ConnectionString.DataPropertyName = "ConnectionString";
            ConnectionString.HeaderText = "ConnectionString";
            ConnectionString.Name = "ConnectionString";
            ConnectionString.ReadOnly = true;
            ConnectionString.Width = 151;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "CompanyName";
            dataGridViewTextBoxColumn2.HeaderText = "CompanyName";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 152;
            // 
            // DescriptionConnectionStateColumn
            // 
            DescriptionConnectionStateColumn.DataPropertyName = "DescriptionConnectionState";
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            DescriptionConnectionStateColumn.DefaultCellStyle = dataGridViewCellStyle1;
            DescriptionConnectionStateColumn.HeaderText = "Состояние соединения";
            DescriptionConnectionStateColumn.Name = "DescriptionConnectionStateColumn";
            DescriptionConnectionStateColumn.ReadOnly = true;
            DescriptionConnectionStateColumn.Width = 152;
            // 
            // ConnectionStateErrorDetails
            // 
            ConnectionStateErrorDetails.DataPropertyName = "ConnectionStateErrorDetails";
            ConnectionStateErrorDetails.HeaderText = "ConnectionStateErrorDetails";
            ConnectionStateErrorDetails.Name = "ConnectionStateErrorDetails";
            ConnectionStateErrorDetails.ReadOnly = true;
            ConnectionStateErrorDetails.Width = 300;
            // 
            // utmParamsBindingSource
            // 
            utmParamsBindingSource.DataSource = typeof(AMcore.Models.UtmParam);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSB_Add, TSB_Edit, TSB_Refresh });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(81, 25);
            toolStrip1.TabIndex = 0;
            // 
            // TSB_Add
            // 
            TSB_Add.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSB_Add.Image = (Image)resources.GetObject("TSB_Add.Image");
            TSB_Add.ImageTransparentColor = Color.Magenta;
            TSB_Add.Name = "TSB_Add";
            TSB_Add.Size = new Size(23, 22);
            TSB_Add.Text = "Add";
            TSB_Add.Click += TSB_Add_Click;
            // 
            // TSB_Edit
            // 
            TSB_Edit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSB_Edit.Image = (Image)resources.GetObject("TSB_Edit.Image");
            TSB_Edit.ImageTransparentColor = Color.Magenta;
            TSB_Edit.Name = "TSB_Edit";
            TSB_Edit.Size = new Size(23, 22);
            TSB_Edit.Text = "toolStripButton1";
            // 
            // TSB_Refresh
            // 
            TSB_Refresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            TSB_Refresh.Image = (Image)resources.GetObject("TSB_Refresh.Image");
            TSB_Refresh.ImageTransparentColor = Color.Magenta;
            TSB_Refresh.Name = "TSB_Refresh";
            TSB_Refresh.Size = new Size(23, 22);
            TSB_Refresh.Text = "Обновить стостояние";
            TSB_Refresh.Click += TSB_Refresh_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmiConnect, tsmiOpenVpn, tsmiPing });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(196, 70);
            // 
            // tsmiConnect
            // 
            tsmiConnect.Name = "tsmiConnect";
            tsmiConnect.Size = new Size(195, 22);
            tsmiConnect.Text = "Подключиться (putty)";
            tsmiConnect.Click += TsmiConnect_Click;
            // 
            // tsmiOpenVpn
            // 
            tsmiOpenVpn.Name = "tsmiOpenVpn";
            tsmiOpenVpn.Size = new Size(195, 22);
            tsmiOpenVpn.Text = "Открыть УТМ";
            tsmiOpenVpn.Click += TsmiOpenVpn_Click;
            // 
            // tsmiPing
            // 
            tsmiPing.Name = "tsmiPing";
            tsmiPing.Size = new Size(195, 22);
            tsmiPing.Text = "Ping";
            tsmiPing.Click += TsmiPing_Click;
            // 
            // IncomingDocumentsCount
            // 
            IncomingDocumentsCount.DataPropertyName = "IncomingDocumentsCount";
            IncomingDocumentsCount.HeaderText = "Количество входящих документов";
            IncomingDocumentsCount.Name = "IncomingDocumentsCount";
            IncomingDocumentsCount.ReadOnly = true;
            // 
            // OutgoingDocumentsCount
            // 
            OutgoingDocumentsCount.DataPropertyName = "OutgoingDocumentsCount";
            OutgoingDocumentsCount.HeaderText = "Количество исходящих документов";
            OutgoingDocumentsCount.Name = "OutgoingDocumentsCount";
            OutgoingDocumentsCount.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Name = "MainForm";
            Text = "MainForm";
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)utmParamsBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton TSB_Add;
        private DataGridView DataGrid;
        private BindingSource utmParamsBindingSource;
        private ToolStripButton TSB_Edit;
        private ToolStripButton TSB_Refresh;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripSplitButton TSBIStopUpdateStop;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Version;
        private DataGridViewTextBoxColumn ConnectionString;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn DescriptionConnectionStateColumn;
        private DataGridViewTextBoxColumn ConnectionStateErrorDetails;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmiConnect;
        private ToolStripMenuItem tsmiOpenVpn;
        private ToolStripMenuItem tsmiPing;
        private DataGridViewTextBoxColumn IncomingDocumentsCount;
        private DataGridViewTextBoxColumn OutgoingDocumentsCount;
    }
}