namespace WindowsFormsApplication1
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdTransferData = new System.Windows.Forms.Button();
			this.cmdOK = new System.Windows.Forms.Button();
			this.cmdView = new System.Windows.Forms.Button();
			this.grdDBUtility = new System.Windows.Forms.DataGridView();
			this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grdDBUtility)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdTransferData
			// 
			this.cmdTransferData.BackColor = System.Drawing.Color.Silver;
			this.cmdTransferData.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdTransferData.Location = new System.Drawing.Point(16, 144);
			this.cmdTransferData.Name = "cmdTransferData";
			this.cmdTransferData.Size = new System.Drawing.Size(107, 28);
			this.cmdTransferData.TabIndex = 11;
			this.cmdTransferData.Text = "Transfer Data";
			this.cmdTransferData.UseVisualStyleBackColor = false;
			this.cmdTransferData.Click += new System.EventHandler(this.cmdTransferData_Click);
			// 
			// cmdOK
			// 
			this.cmdOK.BackColor = System.Drawing.Color.Silver;
			this.cmdOK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdOK.Image = ((System.Drawing.Image)(resources.GetObject("cmdOK.Image")));
			this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdOK.Location = new System.Drawing.Point(390, 144);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(72, 28);
			this.cmdOK.TabIndex = 53;
			this.cmdOK.Text = " &Close";
			this.cmdOK.UseVisualStyleBackColor = false;
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// cmdView
			// 
			this.cmdView.BackColor = System.Drawing.Color.Silver;
			this.cmdView.Location = new System.Drawing.Point(155, 144);
			this.cmdView.Name = "cmdView";
			this.cmdView.Size = new System.Drawing.Size(115, 28);
			this.cmdView.TabIndex = 54;
			this.cmdView.Text = "View Log File";
			this.cmdView.UseVisualStyleBackColor = false;
			this.cmdView.Click += new System.EventHandler(this.cmdView_Click);
			// 
			// grdDBUtility
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdDBUtility.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.grdDBUtility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDBUtility.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.grdDBUtility.Location = new System.Drawing.Point(16, 26);
			this.grdDBUtility.Name = "grdDBUtility";
			this.grdDBUtility.RowHeadersVisible = false;
			this.grdDBUtility.Size = new System.Drawing.Size(446, 94);
			this.grdDBUtility.TabIndex = 190;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Status";
			this.Column4.Name = "Column4";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Target DB";
			this.Column3.Name = "Column3";
			this.Column3.Width = 120;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Source DB";
			this.Column2.Name = "Column2";
			this.Column2.Width = 120;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Module";
			this.Column1.Name = "Column1";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 189);
			this.ControlBox = false;
			this.Controls.Add(this.grdDBUtility);
			this.Controls.Add(this.cmdTransferData);
			this.Controls.Add(this.cmdView);
			this.Controls.Add(this.cmdOK);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Data Transfer Utility 1.0";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdDBUtility)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdView;
		private System.Windows.Forms.Button cmdTransferData;
		private System.Windows.Forms.DataGridView grdDBUtility;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
	}
}

