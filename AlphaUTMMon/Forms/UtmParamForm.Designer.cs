namespace AlphaUTMMon.Forms
{
    partial class UtmParamForm
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
            this.BtSave = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.TBFSRARID = new System.Windows.Forms.TextBox();
            this.LFSRARID = new System.Windows.Forms.Label();
            this.LAddress = new System.Windows.Forms.Label();
            this.LPort = new System.Windows.Forms.Label();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.TBPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtSave
            // 
            this.BtSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSave.Location = new System.Drawing.Point(48, 264);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(75, 23);
            this.BtSave.TabIndex = 0;
            this.BtSave.Text = "Сохранить";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCancel.Location = new System.Drawing.Point(129, 264);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(75, 23);
            this.BtCancel.TabIndex = 1;
            this.BtCancel.Text = "Отмена";
            this.BtCancel.UseVisualStyleBackColor = true;
            // 
            // TBFSRARID
            // 
            this.TBFSRARID.Location = new System.Drawing.Point(12, 27);
            this.TBFSRARID.MaxLength = 13;
            this.TBFSRARID.Name = "TBFSRARID";
            this.TBFSRARID.Size = new System.Drawing.Size(190, 23);
            this.TBFSRARID.TabIndex = 2;
            // 
            // LFSRARID
            // 
            this.LFSRARID.AutoSize = true;
            this.LFSRARID.Location = new System.Drawing.Point(12, 9);
            this.LFSRARID.Name = "LFSRARID";
            this.LFSRARID.Size = new System.Drawing.Size(60, 15);
            this.LFSRARID.TabIndex = 3;
            this.LFSRARID.Text = "ФСРАР ID";
            // 
            // LAddress
            // 
            this.LAddress.AutoSize = true;
            this.LAddress.Location = new System.Drawing.Point(12, 53);
            this.LAddress.Name = "LAddress";
            this.LAddress.Size = new System.Drawing.Size(40, 15);
            this.LAddress.TabIndex = 4;
            this.LAddress.Text = "Адрес";
            this.LAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LPort
            // 
            this.LPort.AutoSize = true;
            this.LPort.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LPort.Location = new System.Drawing.Point(164, 53);
            this.LPort.Name = "LPort";
            this.LPort.Size = new System.Drawing.Size(35, 15);
            this.LPort.TabIndex = 5;
            this.LPort.Text = "Порт";
            // 
            // TBAddress
            // 
            this.TBAddress.Location = new System.Drawing.Point(12, 71);
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TBAddress.Size = new System.Drawing.Size(145, 23);
            this.TBAddress.TabIndex = 6;
            // 
            // TBPort
            // 
            this.TBPort.Location = new System.Drawing.Point(164, 71);
            this.TBPort.MaxLength = 5;
            this.TBPort.Name = "TBPort";
            this.TBPort.Size = new System.Drawing.Size(38, 23);
            this.TBPort.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(154, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // UtmParamForm
            // 
            this.AcceptButton = this.BtSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtCancel;
            this.ClientSize = new System.Drawing.Size(216, 299);
            this.Controls.Add(this.TBPort);
            this.Controls.Add(this.TBAddress);
            this.Controls.Add(this.LPort);
            this.Controls.Add(this.LAddress);
            this.Controls.Add(this.LFSRARID);
            this.Controls.Add(this.TBFSRARID);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.label4);
            this.MinimumSize = new System.Drawing.Size(232, 338);
            this.Name = "UtmParamForm";
            this.Text = "Параметры УТМ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtSave;
        private Button BtCancel;
        private TextBox TBFSRARID;
        private Label LFSRARID;
        private Label LAddress;
        private Label LPort;
        private TextBox TBAddress;
        private TextBox TBPort;
        private Label label4;
    }
}