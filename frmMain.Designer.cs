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
			this.cmdCopy_Part = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmdCopy_Test = new System.Windows.Forms.Button();
			this.cmdOK = new System.Windows.Forms.Button();
			this.cmdView = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdCopy_Part
			// 
			this.cmdCopy_Part.BackColor = System.Drawing.Color.Silver;
			this.cmdCopy_Part.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCopy_Part.Location = new System.Drawing.Point(16, 24);
			this.cmdCopy_Part.Name = "cmdCopy_Part";
			this.cmdCopy_Part.Size = new System.Drawing.Size(98, 28);
			this.cmdCopy_Part.TabIndex = 10;
			this.cmdCopy_Part.Text = "SealPart";
			this.cmdCopy_Part.UseVisualStyleBackColor = false;
			this.cmdCopy_Part.Click += new System.EventHandler(this.cmdDataTransfer_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmdCopy_Test);
			this.groupBox1.Controls.Add(this.cmdCopy_Part);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(26, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(254, 68);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Copy Record:";
			// 
			// cmdCopy_Test
			// 
			this.cmdCopy_Test.BackColor = System.Drawing.Color.Silver;
			this.cmdCopy_Test.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCopy_Test.Location = new System.Drawing.Point(145, 24);
			this.cmdCopy_Test.Name = "cmdCopy_Test";
			this.cmdCopy_Test.Size = new System.Drawing.Size(98, 28);
			this.cmdCopy_Test.TabIndex = 10;
			this.cmdCopy_Test.Text = "SealTest";
			this.cmdCopy_Test.UseVisualStyleBackColor = false;
			this.cmdCopy_Test.Click += new System.EventHandler(this.cmdCopy_Test_Click);
			// 
			// cmdOK
			// 
			this.cmdOK.BackColor = System.Drawing.Color.Silver;
			this.cmdOK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdOK.Image = ((System.Drawing.Image)(resources.GetObject("cmdOK.Image")));
			this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdOK.Location = new System.Drawing.Point(208, 105);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(72, 28);
			this.cmdOK.TabIndex = 53;
			this.cmdOK.Text = "&OK";
			this.cmdOK.UseVisualStyleBackColor = false;
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// cmdView
			// 
			this.cmdView.BackColor = System.Drawing.Color.Silver;
			this.cmdView.Location = new System.Drawing.Point(33, 105);
			this.cmdView.Name = "cmdView";
			this.cmdView.Size = new System.Drawing.Size(115, 28);
			this.cmdView.TabIndex = 54;
			this.cmdView.Text = "View Log File";
			this.cmdView.UseVisualStyleBackColor = false;
			this.cmdView.Click += new System.EventHandler(this.cmdView_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 145);
			this.ControlBox = false;
			this.Controls.Add(this.cmdView);
			this.Controls.Add(this.cmdOK);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmMain";
			this.Text = "Data Transfer Utility Program";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCopy_Part;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCopy_Test;
        internal System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdView;
    }
}

