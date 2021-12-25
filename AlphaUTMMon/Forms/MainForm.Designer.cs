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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.TSBIStopUpdateStop = new System.Windows.Forms.ToolStripSplitButton();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.utmParamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Add = new System.Windows.Forms.ToolStripButton();
            this.TSB_Edit = new System.Windows.Forms.ToolStripButton();
            this.TSB_Refresh = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionConnectionStateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionStateErrorDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utmParamsBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DataGrid);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.TSBIStopUpdateStop});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(451, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(166, 17);
            this.toolStripStatusLabel1.Text = "Обновление состояния УТМ:";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            this.toolStripProgressBar1.Step = 1;
            // 
            // TSBIStopUpdateStop
            // 
            this.TSBIStopUpdateStop.Image = ((System.Drawing.Image)(resources.GetObject("TSBIStopUpdateStop.Image")));
            this.TSBIStopUpdateStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBIStopUpdateStop.Name = "TSBIStopUpdateStop";
            this.TSBIStopUpdateStop.Size = new System.Drawing.Size(66, 20);
            this.TSBIStopUpdateStop.Text = "Стоп";
            this.TSBIStopUpdateStop.ButtonClick += new System.EventHandler(this.TSBIStopUpdateStop_ButtonClick);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Version,
            this.ConnectionString,
            this.dataGridViewTextBoxColumn2,
            this.DescriptionConnectionStateColumn,
            this.ConnectionStateErrorDetails});
            this.DataGrid.DataSource = this.utmParamsBindingSource;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowTemplate.Height = 25;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(800, 425);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_CellMouseClick);
            // 
            // utmParamsBindingSource
            // 
            this.utmParamsBindingSource.DataSource = typeof(AMcore.Models.UtmParam);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Add,
            this.TSB_Edit,
            this.TSB_Refresh});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // TSB_Add
            // 
            this.TSB_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Add.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Add.Image")));
            this.TSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Add.Name = "TSB_Add";
            this.TSB_Add.Size = new System.Drawing.Size(23, 22);
            this.TSB_Add.Text = "Add";
            this.TSB_Add.Click += new System.EventHandler(this.TSB_Add_Click);
            // 
            // TSB_Edit
            // 
            this.TSB_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Edit.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Edit.Image")));
            this.TSB_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Edit.Name = "TSB_Edit";
            this.TSB_Edit.Size = new System.Drawing.Size(23, 22);
            this.TSB_Edit.Text = "toolStripButton1";
            // 
            // TSB_Refresh
            // 
            this.TSB_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Refresh.Image")));
            this.TSB_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Refresh.Name = "TSB_Refresh";
            this.TSB_Refresh.Size = new System.Drawing.Size(23, 22);
            this.TSB_Refresh.Text = "Обновить стостояние";
            this.TSB_Refresh.Click += new System.EventHandler(this.TSB_Refresh_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FSRARID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FSRARID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 151;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "Version";
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // ConnectionString
            // 
            this.ConnectionString.DataPropertyName = "ConnectionString";
            this.ConnectionString.HeaderText = "ConnectionString";
            this.ConnectionString.Name = "ConnectionString";
            this.ConnectionString.ReadOnly = true;
            this.ConnectionString.Width = 151;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 152;
            // 
            // DescriptionConnectionStateColumn
            // 
            this.DescriptionConnectionStateColumn.DataPropertyName = "DescriptionConnectionState";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DescriptionConnectionStateColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.DescriptionConnectionStateColumn.HeaderText = "Состояние соединения";
            this.DescriptionConnectionStateColumn.Name = "DescriptionConnectionStateColumn";
            this.DescriptionConnectionStateColumn.ReadOnly = true;
            this.DescriptionConnectionStateColumn.Width = 152;
            // 
            // ConnectionStateErrorDetails
            // 
            this.ConnectionStateErrorDetails.DataPropertyName = "ConnectionStateErrorDetails";
            this.ConnectionStateErrorDetails.HeaderText = "ConnectionStateErrorDetails";
            this.ConnectionStateErrorDetails.Name = "ConnectionStateErrorDetails";
            this.ConnectionStateErrorDetails.ReadOnly = true;
            this.ConnectionStateErrorDetails.Width = 300;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utmParamsBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}