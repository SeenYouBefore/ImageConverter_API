namespace ImgConvertingApp
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
            this.JPG = new System.Windows.Forms.Button();
            this.PNG = new System.Windows.Forms.Button();
            this.GIF = new System.Windows.Forms.Button();
            this.Scew = new System.Windows.Forms.Button();
            this.Crop = new System.Windows.Forms.Button();
            this.KeepAspect = new System.Windows.Forms.Button();
            this.UploadFile = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelWidth = new System.Windows.Forms.Label();
            this.TextBox_Width = new System.Windows.Forms.TextBox();
            this.TextBox_Height = new System.Windows.Forms.TextBox();
            this.LableHeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // JPG
            // 
            this.JPG.Location = new System.Drawing.Point(12, 12);
            this.JPG.Name = "JPG";
            this.JPG.Size = new System.Drawing.Size(75, 23);
            this.JPG.TabIndex = 0;
            this.JPG.Text = "JPG";
            this.JPG.UseVisualStyleBackColor = true;
            this.JPG.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PNG
            // 
            this.PNG.Location = new System.Drawing.Point(12, 41);
            this.PNG.Name = "PNG";
            this.PNG.Size = new System.Drawing.Size(75, 23);
            this.PNG.TabIndex = 1;
            this.PNG.Text = "PNG";
            this.PNG.UseVisualStyleBackColor = true;
            this.PNG.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GIF
            // 
            this.GIF.Location = new System.Drawing.Point(13, 71);
            this.GIF.Name = "GIF";
            this.GIF.Size = new System.Drawing.Size(75, 23);
            this.GIF.TabIndex = 2;
            this.GIF.Text = "GIF";
            this.GIF.UseVisualStyleBackColor = true;
            this.GIF.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Scew
            // 
            this.Scew.Location = new System.Drawing.Point(13, 145);
            this.Scew.Name = "Scew";
            this.Scew.Size = new System.Drawing.Size(75, 23);
            this.Scew.TabIndex = 3;
            this.Scew.Text = "Scew";
            this.Scew.UseVisualStyleBackColor = true;
            this.Scew.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Crop
            // 
            this.Crop.Location = new System.Drawing.Point(13, 175);
            this.Crop.Name = "Crop";
            this.Crop.Size = new System.Drawing.Size(75, 23);
            this.Crop.TabIndex = 4;
            this.Crop.Text = "Crop";
            this.Crop.UseVisualStyleBackColor = true;
            this.Crop.Click += new System.EventHandler(this.Button5_Click);
            // 
            // KeepAspect
            // 
            this.KeepAspect.Location = new System.Drawing.Point(13, 205);
            this.KeepAspect.Name = "KeepAspect";
            this.KeepAspect.Size = new System.Drawing.Size(75, 23);
            this.KeepAspect.TabIndex = 5;
            this.KeepAspect.Text = "KeepAspect";
            this.KeepAspect.UseVisualStyleBackColor = true;
            this.KeepAspect.Click += new System.EventHandler(this.Button6_Click);
            // 
            // UploadFile
            // 
            this.UploadFile.Location = new System.Drawing.Point(13, 286);
            this.UploadFile.Name = "UploadFile";
            this.UploadFile.Size = new System.Drawing.Size(75, 23);
            this.UploadFile.TabIndex = 6;
            this.UploadFile.Text = "Upload File";
            this.UploadFile.UseVisualStyleBackColor = true;
            this.UploadFile.Click += new System.EventHandler(this.Button7_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PictureBox1.Location = new System.Drawing.Point(391, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(548, 263);
            this.PictureBox1.TabIndex = 7;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Location = new System.Drawing.Point(103, 214);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(60, 13);
            this.LabelWidth.TabIndex = 10;
            this.LabelWidth.Text = "New Width";
            // 
            // TextBox_Width
            // 
            this.TextBox_Width.Location = new System.Drawing.Point(169, 207);
            this.TextBox_Width.Name = "TextBox_Width";
            this.TextBox_Width.Size = new System.Drawing.Size(58, 20);
            this.TextBox_Width.TabIndex = 12;
            // 
            // TextBox_Height
            // 
            this.TextBox_Height.Location = new System.Drawing.Point(288, 207);
            this.TextBox_Height.Name = "TextBox_Height";
            this.TextBox_Height.Size = new System.Drawing.Size(69, 20);
            this.TextBox_Height.TabIndex = 13;
            // 
            // LableHeight
            // 
            this.LableHeight.AutoSize = true;
            this.LableHeight.Location = new System.Drawing.Point(244, 213);
            this.LableHeight.Name = "LableHeight";
            this.LableHeight.Size = new System.Drawing.Size(38, 13);
            this.LableHeight.TabIndex = 14;
            this.LableHeight.Text = "Height";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 321);
            this.Controls.Add(this.LableHeight);
            this.Controls.Add(this.TextBox_Height);
            this.Controls.Add(this.TextBox_Width);
            this.Controls.Add(this.LabelWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.UploadFile);
            this.Controls.Add(this.KeepAspect);
            this.Controls.Add(this.Crop);
            this.Controls.Add(this.Scew);
            this.Controls.Add(this.GIF);
            this.Controls.Add(this.PNG);
            this.Controls.Add(this.JPG);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JPG;
        private System.Windows.Forms.Button PNG;
        private System.Windows.Forms.Button GIF;
        private System.Windows.Forms.Button Scew;
        private System.Windows.Forms.Button Crop;
        private System.Windows.Forms.Button KeepAspect;
        private System.Windows.Forms.Button UploadFile;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.TextBox TextBox_Width;
        private System.Windows.Forms.TextBox TextBox_Height;
        private System.Windows.Forms.Label LableHeight;
    }
}

