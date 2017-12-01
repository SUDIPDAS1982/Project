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
            this.cmdDelete_Part = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdDelete_Test = new System.Windows.Forms.Button();
            this.cmdCopy_Test = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCopy_Part
            // 
            this.cmdCopy_Part.Location = new System.Drawing.Point(142, 28);
            this.cmdCopy_Part.Name = "cmdCopy_Part";
            this.cmdCopy_Part.Size = new System.Drawing.Size(99, 23);
            this.cmdCopy_Part.TabIndex = 10;
            this.cmdCopy_Part.Text = "Copy Records";
            this.cmdCopy_Part.UseVisualStyleBackColor = true;
            this.cmdCopy_Part.Click += new System.EventHandler(this.cmdDataTransfer_Click);
            // 
            // cmdDelete_Part
            // 
            this.cmdDelete_Part.Location = new System.Drawing.Point(20, 28);
            this.cmdDelete_Part.Name = "cmdDelete_Part";
            this.cmdDelete_Part.Size = new System.Drawing.Size(105, 23);
            this.cmdDelete_Part.TabIndex = 11;
            this.cmdDelete_Part.Text = "Delete Records";
            this.cmdDelete_Part.UseVisualStyleBackColor = true;
            this.cmdDelete_Part.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdDelete_Part);
            this.groupBox1.Controls.Add(this.cmdCopy_Part);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 68);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SealPart:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdDelete_Test);
            this.groupBox2.Controls.Add(this.cmdCopy_Test);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 68);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SealTest:";
            // 
            // cmdDelete_Test
            // 
            this.cmdDelete_Test.Location = new System.Drawing.Point(20, 28);
            this.cmdDelete_Test.Name = "cmdDelete_Test";
            this.cmdDelete_Test.Size = new System.Drawing.Size(105, 23);
            this.cmdDelete_Test.TabIndex = 11;
            this.cmdDelete_Test.Text = "Delete Records";
            this.cmdDelete_Test.UseVisualStyleBackColor = true;
            this.cmdDelete_Test.Click += new System.EventHandler(this.cmdDelete_Test_Click);
            // 
            // cmdCopy_Test
            // 
            this.cmdCopy_Test.Location = new System.Drawing.Point(142, 28);
            this.cmdCopy_Test.Name = "cmdCopy_Test";
            this.cmdCopy_Test.Size = new System.Drawing.Size(99, 23);
            this.cmdCopy_Test.TabIndex = 10;
            this.cmdCopy_Test.Text = "Copy Records";
            this.cmdCopy_Test.UseVisualStyleBackColor = true;
            this.cmdCopy_Test.Click += new System.EventHandler(this.cmdCopy_Test_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(331, 29);
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
            this.ClientSize = new System.Drawing.Size(562, 249);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCopy_Part;
        private System.Windows.Forms.Button cmdDelete_Part;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdDelete_Test;
        private System.Windows.Forms.Button cmdCopy_Test;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

