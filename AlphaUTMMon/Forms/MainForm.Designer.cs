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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionConnectionState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uTMConnectionStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utmParamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Add = new System.Windows.Forms.ToolStripButton();
            this.TSB_Edit = new System.Windows.Forms.ToolStripButton();
            this.TSB_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utmParamsBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DescriptionConnectionState,
            this.ConnectionString,
            this.dataGridViewTextBoxColumn2,
            this.uTMConnectionStateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utmParamsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FSRARID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FSRARID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DescriptionConnectionState
            // 
            this.DescriptionConnectionState.DataPropertyName = "DescriptionConnectionState";
            this.DescriptionConnectionState.HeaderText = "DescriptionConnectionState";
            this.DescriptionConnectionState.Name = "DescriptionConnectionState";
            this.DescriptionConnectionState.ReadOnly = true;
            // 
            // ConnectionString
            // 
            this.ConnectionString.DataPropertyName = "ConnectionString";
            this.ConnectionString.HeaderText = "ConnectionString";
            this.ConnectionString.Name = "ConnectionString";
            this.ConnectionString.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CompanyName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // uTMConnectionStateDataGridViewTextBoxColumn
            // 
            this.uTMConnectionStateDataGridViewTextBoxColumn.DataPropertyName = "UTMConnectionState";
            this.uTMConnectionStateDataGridViewTextBoxColumn.HeaderText = "UTMConnectionState";
            this.uTMConnectionStateDataGridViewTextBoxColumn.Name = "uTMConnectionStateDataGridViewTextBoxColumn";
            this.uTMConnectionStateDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(112, 25);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utmParamsBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton TSB_Add;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fSRARIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn connectionAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn connectionPortDataGridViewTextBoxColumn;
        private BindingSource utmParamsBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn DescriptionConnectionState;
        private DataGridViewTextBoxColumn ConnectionString;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn uTMConnectionStateDataGridViewTextBoxColumn;
        private ToolStripButton TSB_Edit;
        private ToolStripButton TSB_Refresh;
    }
}