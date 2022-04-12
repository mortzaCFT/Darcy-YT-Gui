namespace DarcyYT
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FPSDropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QualityDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.downloadPathTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // URLTextBox
            // 
            this.URLTextBox.BackColor = System.Drawing.Color.Goldenrod;
            this.URLTextBox.Location = new System.Drawing.Point(9, 156);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(280, 20);
            this.URLTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // FPSDropDown
            // 
            this.FPSDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FPSDropDown.FormattingEnabled = true;
            this.FPSDropDown.Items.AddRange(new object[] {
            "30",
            "60"});
            this.FPSDropDown.Location = new System.Drawing.Point(143, 243);
            this.FPSDropDown.Name = "FPSDropDown";
            this.FPSDropDown.Size = new System.Drawing.Size(59, 21);
            this.FPSDropDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FPS";
            // 
            // QualityDropDown
            // 
            this.QualityDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QualityDropDown.FormattingEnabled = true;
            this.QualityDropDown.Items.AddRange(new object[] {
            "144p",
            "240p",
            "360p",
            "480p",
            "720p",
            "1080p"});
            this.QualityDropDown.Location = new System.Drawing.Point(9, 243);
            this.QualityDropDown.Name = "QualityDropDown";
            this.QualityDropDown.Size = new System.Drawing.Size(109, 21);
            this.QualityDropDown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Video Quality";
            // 
            // DownloadButton
            // 
            this.DownloadButton.BackColor = System.Drawing.Color.Goldenrod;
            this.DownloadButton.ForeColor = System.Drawing.Color.Black;
            this.DownloadButton.Location = new System.Drawing.Point(9, 298);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(128, 100);
            this.DownloadButton.TabIndex = 6;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = false;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(276, 201);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(27, 23);
            this.selectFolderButton.TabIndex = 7;
            this.selectFolderButton.Text = "...";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // downloadPathTxtBox
            // 
            this.downloadPathTxtBox.BackColor = System.Drawing.Color.Goldenrod;
            this.downloadPathTxtBox.Location = new System.Drawing.Point(9, 204);
            this.downloadPathTxtBox.Name = "downloadPathTxtBox";
            this.downloadPathTxtBox.ReadOnly = true;
            this.downloadPathTxtBox.Size = new System.Drawing.Size(261, 20);
            this.downloadPathTxtBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Download path ";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select folder to which you wish to store your downloaded video";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Goldenrod;
            this.UpdateButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateButton.Location = new System.Drawing.Point(143, 319);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(59, 80);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update Backend";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(208, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(208, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Darcy-Team";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 126);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(311, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.downloadPathTxtBox);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QualityDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FPSDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URLTextBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "DarcyYT";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FPSDropDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox QualityDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox downloadPathTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

