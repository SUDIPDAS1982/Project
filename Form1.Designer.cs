namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.cmdCopy_Part = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCopy_Test = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCopy_Part
            // 
            this.cmdCopy_Part.Location = new System.Drawing.Point(6, 29);
            this.cmdCopy_Part.Name = "cmdCopy_Part";
            this.cmdCopy_Part.Size = new System.Drawing.Size(99, 23);
            this.cmdCopy_Part.TabIndex = 10;
            this.cmdCopy_Part.Text = "SealPart";
            this.cmdCopy_Part.UseVisualStyleBackColor = true;
            this.cmdCopy_Part.Click += new System.EventHandler(this.cmdDataTransfer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCopy_Test);
            this.groupBox1.Controls.Add(this.cmdCopy_Part);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 68);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copy:";
            // 
            // cmdCopy_Test
            // 
            this.cmdCopy_Test.Location = new System.Drawing.Point(121, 29);
            this.cmdCopy_Test.Name = "cmdCopy_Test";
            this.cmdCopy_Test.Size = new System.Drawing.Size(99, 23);
            this.cmdCopy_Test.TabIndex = 10;
            this.cmdCopy_Test.Text = "SealTest";
            this.cmdCopy_Test.UseVisualStyleBackColor = true;
            this.cmdCopy_Test.Click += new System.EventHandler(this.cmdCopy_Test_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(302, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 199);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCopy_Part;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCopy_Test;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

