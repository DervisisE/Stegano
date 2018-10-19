namespace Stegano
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
            this.coverImage = new System.Windows.Forms.PictureBox();
            this.secretImage = new System.Windows.Forms.PictureBox();
            this.btnUploadCoverImg = new System.Windows.Forms.Button();
            this.btnUploadSecretImage = new System.Windows.Forms.Button();
            this.btnCreateStegoImage = new System.Windows.Forms.Button();
            this.extractedSecretImage = new System.Windows.Forms.PictureBox();
            this.btnExtractSecretImage = new System.Windows.Forms.Button();
            this.btnUploadStegoImage = new System.Windows.Forms.Button();
            this.btnSaveExtractedImage = new System.Windows.Forms.Button();
            this.btnSaveStegoImage = new System.Windows.Forms.Button();
            this.stegoImage = new System.Windows.Forms.PictureBox();
            this.CoverTb = new System.Windows.Forms.TextBox();
            this.SecretTb = new System.Windows.Forms.TextBox();
            this.CreateStegoTb = new System.Windows.Forms.TextBox();
            this.StegoTb = new System.Windows.Forms.TextBox();
            this.SaveStegoTb = new System.Windows.Forms.TextBox();
            this.EtractSecretTb = new System.Windows.Forms.TextBox();
            this.SaveEtractedTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extractedSecretImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stegoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // coverImage
            // 
            this.coverImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.coverImage.Location = new System.Drawing.Point(12, 12);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(500, 300);
            this.coverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverImage.TabIndex = 0;
            this.coverImage.TabStop = false;
            // 
            // secretImage
            // 
            this.secretImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secretImage.Location = new System.Drawing.Point(973, 12);
            this.secretImage.Name = "secretImage";
            this.secretImage.Size = new System.Drawing.Size(500, 300);
            this.secretImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secretImage.TabIndex = 1;
            this.secretImage.TabStop = false;
            // 
            // btnUploadCoverImg
            // 
            this.btnUploadCoverImg.BackColor = System.Drawing.Color.DimGray;
            this.btnUploadCoverImg.Location = new System.Drawing.Point(12, 318);
            this.btnUploadCoverImg.Name = "btnUploadCoverImg";
            this.btnUploadCoverImg.Size = new System.Drawing.Size(149, 26);
            this.btnUploadCoverImg.TabIndex = 2;
            this.btnUploadCoverImg.Text = "Upload Cover Image";
            this.btnUploadCoverImg.UseVisualStyleBackColor = false;
            this.btnUploadCoverImg.Click += new System.EventHandler(this.btnUploadCoverImg_Click);
            // 
            // btnUploadSecretImage
            // 
            this.btnUploadSecretImage.BackColor = System.Drawing.Color.DimGray;
            this.btnUploadSecretImage.Enabled = false;
            this.btnUploadSecretImage.Location = new System.Drawing.Point(973, 318);
            this.btnUploadSecretImage.Name = "btnUploadSecretImage";
            this.btnUploadSecretImage.Size = new System.Drawing.Size(149, 26);
            this.btnUploadSecretImage.TabIndex = 4;
            this.btnUploadSecretImage.Text = "Upload Secret Image";
            this.btnUploadSecretImage.UseVisualStyleBackColor = false;
            this.btnUploadSecretImage.Click += new System.EventHandler(this.btnUploadSecretImage_Click);
            // 
            // btnCreateStegoImage
            // 
            this.btnCreateStegoImage.BackColor = System.Drawing.Color.DimGray;
            this.btnCreateStegoImage.Enabled = false;
            this.btnCreateStegoImage.Location = new System.Drawing.Point(12, 362);
            this.btnCreateStegoImage.Name = "btnCreateStegoImage";
            this.btnCreateStegoImage.Size = new System.Drawing.Size(149, 26);
            this.btnCreateStegoImage.TabIndex = 5;
            this.btnCreateStegoImage.Text = "Create Stego Image";
            this.btnCreateStegoImage.UseVisualStyleBackColor = false;
            this.btnCreateStegoImage.Click += new System.EventHandler(this.btnCreateStegoImage_Click);
            // 
            // extractedSecretImage
            // 
            this.extractedSecretImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.extractedSecretImage.Location = new System.Drawing.Point(973, 394);
            this.extractedSecretImage.Name = "extractedSecretImage";
            this.extractedSecretImage.Size = new System.Drawing.Size(500, 300);
            this.extractedSecretImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.extractedSecretImage.TabIndex = 6;
            this.extractedSecretImage.TabStop = false;
            // 
            // btnExtractSecretImage
            // 
            this.btnExtractSecretImage.BackColor = System.Drawing.Color.DimGray;
            this.btnExtractSecretImage.Enabled = false;
            this.btnExtractSecretImage.Location = new System.Drawing.Point(973, 700);
            this.btnExtractSecretImage.Name = "btnExtractSecretImage";
            this.btnExtractSecretImage.Size = new System.Drawing.Size(149, 26);
            this.btnExtractSecretImage.TabIndex = 7;
            this.btnExtractSecretImage.Text = "Extract Secret Image";
            this.btnExtractSecretImage.UseVisualStyleBackColor = false;
            this.btnExtractSecretImage.Click += new System.EventHandler(this.btnExtractSecretImage_Click);
            // 
            // btnUploadStegoImage
            // 
            this.btnUploadStegoImage.BackColor = System.Drawing.Color.DimGray;
            this.btnUploadStegoImage.Location = new System.Drawing.Point(12, 700);
            this.btnUploadStegoImage.Name = "btnUploadStegoImage";
            this.btnUploadStegoImage.Size = new System.Drawing.Size(149, 26);
            this.btnUploadStegoImage.TabIndex = 8;
            this.btnUploadStegoImage.Text = "Upload Stego Image";
            this.btnUploadStegoImage.UseVisualStyleBackColor = false;
            this.btnUploadStegoImage.Click += new System.EventHandler(this.btnUploadStegoImage_Click);
            // 
            // btnSaveExtractedImage
            // 
            this.btnSaveExtractedImage.BackColor = System.Drawing.Color.DimGray;
            this.btnSaveExtractedImage.Enabled = false;
            this.btnSaveExtractedImage.Location = new System.Drawing.Point(1324, 700);
            this.btnSaveExtractedImage.Name = "btnSaveExtractedImage";
            this.btnSaveExtractedImage.Size = new System.Drawing.Size(149, 26);
            this.btnSaveExtractedImage.TabIndex = 9;
            this.btnSaveExtractedImage.Text = "Save Extracted Image";
            this.btnSaveExtractedImage.UseVisualStyleBackColor = false;
            this.btnSaveExtractedImage.Click += new System.EventHandler(this.btnSaveExtractedImage_Click);
            // 
            // btnSaveStegoImage
            // 
            this.btnSaveStegoImage.BackColor = System.Drawing.Color.DimGray;
            this.btnSaveStegoImage.Enabled = false;
            this.btnSaveStegoImage.Location = new System.Drawing.Point(363, 700);
            this.btnSaveStegoImage.Name = "btnSaveStegoImage";
            this.btnSaveStegoImage.Size = new System.Drawing.Size(149, 26);
            this.btnSaveStegoImage.TabIndex = 10;
            this.btnSaveStegoImage.Text = "Save Stego Image";
            this.btnSaveStegoImage.UseVisualStyleBackColor = false;
            this.btnSaveStegoImage.Click += new System.EventHandler(this.btnSaveStegoImage_Click);
            // 
            // stegoImage
            // 
            this.stegoImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stegoImage.Location = new System.Drawing.Point(12, 394);
            this.stegoImage.Name = "stegoImage";
            this.stegoImage.Size = new System.Drawing.Size(500, 300);
            this.stegoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stegoImage.TabIndex = 11;
            this.stegoImage.TabStop = false;
            // 
            // CoverTb
            // 
            this.CoverTb.BackColor = System.Drawing.Color.DimGray;
            this.CoverTb.Location = new System.Drawing.Point(12, 274);
            this.CoverTb.Multiline = true;
            this.CoverTb.Name = "CoverTb";
            this.CoverTb.ReadOnly = true;
            this.CoverTb.Size = new System.Drawing.Size(243, 38);
            this.CoverTb.TabIndex = 12;
            this.CoverTb.Text = "Select an image to be used as a cover image, in which the secret image will be hi" +
    "dden iside.\r\n";
            this.CoverTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecretTb
            // 
            this.SecretTb.BackColor = System.Drawing.Color.DimGray;
            this.SecretTb.Location = new System.Drawing.Point(973, 274);
            this.SecretTb.Multiline = true;
            this.SecretTb.Name = "SecretTb";
            this.SecretTb.ReadOnly = true;
            this.SecretTb.Size = new System.Drawing.Size(243, 38);
            this.SecretTb.TabIndex = 13;
            this.SecretTb.Text = "Select an image to be hidden inside the cover image.";
            this.SecretTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateStegoTb
            // 
            this.CreateStegoTb.BackColor = System.Drawing.Color.DimGray;
            this.CreateStegoTb.Location = new System.Drawing.Point(12, 394);
            this.CreateStegoTb.Multiline = true;
            this.CreateStegoTb.Name = "CreateStegoTb";
            this.CreateStegoTb.ReadOnly = true;
            this.CreateStegoTb.Size = new System.Drawing.Size(243, 48);
            this.CreateStegoTb.TabIndex = 14;
            this.CreateStegoTb.Text = "Press this button to create the Stegano Image by hidding the secret image into th" +
    "e cover image. This may take a while.\r\n\r\n";
            this.CreateStegoTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StegoTb
            // 
            this.StegoTb.BackColor = System.Drawing.Color.DimGray;
            this.StegoTb.Location = new System.Drawing.Point(12, 646);
            this.StegoTb.Multiline = true;
            this.StegoTb.Name = "StegoTb";
            this.StegoTb.ReadOnly = true;
            this.StegoTb.Size = new System.Drawing.Size(243, 48);
            this.StegoTb.TabIndex = 15;
            this.StegoTb.Text = "Select an Stegano image that will be used to reveal the Secret image inside of it" +
    ". Only Stegano Images will work.";
            this.StegoTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveStegoTb
            // 
            this.SaveStegoTb.BackColor = System.Drawing.Color.DimGray;
            this.SaveStegoTb.Location = new System.Drawing.Point(409, 658);
            this.SaveStegoTb.Multiline = true;
            this.SaveStegoTb.Name = "SaveStegoTb";
            this.SaveStegoTb.ReadOnly = true;
            this.SaveStegoTb.Size = new System.Drawing.Size(103, 36);
            this.SaveStegoTb.TabIndex = 16;
            this.SaveStegoTb.Text = "Save the created Stegano image.";
            this.SaveStegoTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EtractSecretTb
            // 
            this.EtractSecretTb.BackColor = System.Drawing.Color.DimGray;
            this.EtractSecretTb.Location = new System.Drawing.Point(973, 658);
            this.EtractSecretTb.Multiline = true;
            this.EtractSecretTb.Name = "EtractSecretTb";
            this.EtractSecretTb.ReadOnly = true;
            this.EtractSecretTb.Size = new System.Drawing.Size(206, 36);
            this.EtractSecretTb.TabIndex = 17;
            this.EtractSecretTb.Text = "Press this button to Extract the Secret image hidden within the Stegano Image.";
            this.EtractSecretTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaveEtractedTb
            // 
            this.SaveEtractedTb.BackColor = System.Drawing.Color.DimGray;
            this.SaveEtractedTb.Location = new System.Drawing.Point(1324, 658);
            this.SaveEtractedTb.Multiline = true;
            this.SaveEtractedTb.Name = "SaveEtractedTb";
            this.SaveEtractedTb.ReadOnly = true;
            this.SaveEtractedTb.Size = new System.Drawing.Size(149, 36);
            this.SaveEtractedTb.TabIndex = 18;
            this.SaveEtractedTb.Text = "Save the Secret Image tha was extracted.";
            this.SaveEtractedTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1485, 756);
            this.Controls.Add(this.SaveEtractedTb);
            this.Controls.Add(this.EtractSecretTb);
            this.Controls.Add(this.SaveStegoTb);
            this.Controls.Add(this.StegoTb);
            this.Controls.Add(this.CreateStegoTb);
            this.Controls.Add(this.SecretTb);
            this.Controls.Add(this.CoverTb);
            this.Controls.Add(this.stegoImage);
            this.Controls.Add(this.btnSaveStegoImage);
            this.Controls.Add(this.btnSaveExtractedImage);
            this.Controls.Add(this.btnUploadStegoImage);
            this.Controls.Add(this.btnExtractSecretImage);
            this.Controls.Add(this.extractedSecretImage);
            this.Controls.Add(this.btnCreateStegoImage);
            this.Controls.Add(this.btnUploadSecretImage);
            this.Controls.Add(this.btnUploadCoverImg);
            this.Controls.Add(this.secretImage);
            this.Controls.Add(this.coverImage);
            this.Name = "Form1";
            this.Text = "Stegano ";
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extractedSecretImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stegoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverImage;
        private System.Windows.Forms.PictureBox secretImage;
        private System.Windows.Forms.Button btnUploadCoverImg;
        private System.Windows.Forms.Button btnUploadSecretImage;
        private System.Windows.Forms.Button btnCreateStegoImage;
        private System.Windows.Forms.PictureBox extractedSecretImage;
        private System.Windows.Forms.Button btnExtractSecretImage;
        private System.Windows.Forms.Button btnUploadStegoImage;
        private System.Windows.Forms.Button btnSaveExtractedImage;
        private System.Windows.Forms.Button btnSaveStegoImage;
        private System.Windows.Forms.PictureBox stegoImage;
        private System.Windows.Forms.TextBox CoverTb;
        private System.Windows.Forms.TextBox SecretTb;
        private System.Windows.Forms.TextBox CreateStegoTb;
        private System.Windows.Forms.TextBox StegoTb;
        private System.Windows.Forms.TextBox SaveStegoTb;
        private System.Windows.Forms.TextBox EtractSecretTb;
        private System.Windows.Forms.TextBox SaveEtractedTb;
    }
}

