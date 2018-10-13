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
            this.stegoImage = new System.Windows.Forms.PictureBox();
            this.btnUploadSecretImage = new System.Windows.Forms.Button();
            this.btnCreateStegoImage = new System.Windows.Forms.Button();
            this.extractedSecretImage = new System.Windows.Forms.PictureBox();
            this.btnExtractSecretImage = new System.Windows.Forms.Button();
            this.btnUploadStegoImage = new System.Windows.Forms.Button();
            this.btnSaveExtractedImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stegoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extractedSecretImage)).BeginInit();
            this.SuspendLayout();
            // 
            // coverImage
            // 
            this.coverImage.Location = new System.Drawing.Point(12, 12);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(500, 300);
            this.coverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverImage.TabIndex = 0;
            this.coverImage.TabStop = false;
            // 
            // secretImage
            // 
            this.secretImage.Location = new System.Drawing.Point(973, 12);
            this.secretImage.Name = "secretImage";
            this.secretImage.Size = new System.Drawing.Size(500, 300);
            this.secretImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secretImage.TabIndex = 1;
            this.secretImage.TabStop = false;
            // 
            // btnUploadCoverImg
            // 
            this.btnUploadCoverImg.Location = new System.Drawing.Point(12, 318);
            this.btnUploadCoverImg.Name = "btnUploadCoverImg";
            this.btnUploadCoverImg.Size = new System.Drawing.Size(149, 26);
            this.btnUploadCoverImg.TabIndex = 2;
            this.btnUploadCoverImg.Text = "Upload Cover Image";
            this.btnUploadCoverImg.UseVisualStyleBackColor = true;
            this.btnUploadCoverImg.Click += new System.EventHandler(this.button1_Click);
            // 
            // stegoImage
            // 
            this.stegoImage.Location = new System.Drawing.Point(13, 394);
            this.stegoImage.Name = "stegoImage";
            this.stegoImage.Size = new System.Drawing.Size(500, 300);
            this.stegoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stegoImage.TabIndex = 3;
            this.stegoImage.TabStop = false;
            // 
            // btnUploadSecretImage
            // 
            this.btnUploadSecretImage.Location = new System.Drawing.Point(973, 318);
            this.btnUploadSecretImage.Name = "btnUploadSecretImage";
            this.btnUploadSecretImage.Size = new System.Drawing.Size(149, 26);
            this.btnUploadSecretImage.TabIndex = 4;
            this.btnUploadSecretImage.Text = "Upload Secret Image";
            this.btnUploadSecretImage.UseVisualStyleBackColor = true;
            this.btnUploadSecretImage.Click += new System.EventHandler(this.btnUploadSecretImage_Click);
            // 
            // btnCreateStegoImage
            // 
            this.btnCreateStegoImage.Location = new System.Drawing.Point(363, 700);
            this.btnCreateStegoImage.Name = "btnCreateStegoImage";
            this.btnCreateStegoImage.Size = new System.Drawing.Size(149, 26);
            this.btnCreateStegoImage.TabIndex = 5;
            this.btnCreateStegoImage.Text = "Create Stego Image";
            this.btnCreateStegoImage.UseVisualStyleBackColor = true;
            this.btnCreateStegoImage.Click += new System.EventHandler(this.btnCreateStegoImage_Click);
            // 
            // extractedSecretImage
            // 
            this.extractedSecretImage.Location = new System.Drawing.Point(973, 394);
            this.extractedSecretImage.Name = "extractedSecretImage";
            this.extractedSecretImage.Size = new System.Drawing.Size(500, 300);
            this.extractedSecretImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.extractedSecretImage.TabIndex = 6;
            this.extractedSecretImage.TabStop = false;
            // 
            // btnExtractSecretImage
            // 
            this.btnExtractSecretImage.Location = new System.Drawing.Point(973, 700);
            this.btnExtractSecretImage.Name = "btnExtractSecretImage";
            this.btnExtractSecretImage.Size = new System.Drawing.Size(149, 26);
            this.btnExtractSecretImage.TabIndex = 7;
            this.btnExtractSecretImage.Text = "Extract Secret Image";
            this.btnExtractSecretImage.UseVisualStyleBackColor = true;
            // 
            // btnUploadStegoImage
            // 
            this.btnUploadStegoImage.Location = new System.Drawing.Point(12, 700);
            this.btnUploadStegoImage.Name = "btnUploadStegoImage";
            this.btnUploadStegoImage.Size = new System.Drawing.Size(149, 26);
            this.btnUploadStegoImage.TabIndex = 8;
            this.btnUploadStegoImage.Text = "Upload Stego Image";
            this.btnUploadStegoImage.UseVisualStyleBackColor = true;
            // 
            // btnSaveExtractedImage
            // 
            this.btnSaveExtractedImage.Location = new System.Drawing.Point(1324, 700);
            this.btnSaveExtractedImage.Name = "btnSaveExtractedImage";
            this.btnSaveExtractedImage.Size = new System.Drawing.Size(149, 26);
            this.btnSaveExtractedImage.TabIndex = 9;
            this.btnSaveExtractedImage.Text = "Save Extracted Image";
            this.btnSaveExtractedImage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 756);
            this.Controls.Add(this.btnSaveExtractedImage);
            this.Controls.Add(this.btnUploadStegoImage);
            this.Controls.Add(this.btnExtractSecretImage);
            this.Controls.Add(this.extractedSecretImage);
            this.Controls.Add(this.btnCreateStegoImage);
            this.Controls.Add(this.btnUploadSecretImage);
            this.Controls.Add(this.stegoImage);
            this.Controls.Add(this.btnUploadCoverImg);
            this.Controls.Add(this.secretImage);
            this.Controls.Add(this.coverImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stegoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extractedSecretImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox coverImage;
        private System.Windows.Forms.PictureBox secretImage;
        private System.Windows.Forms.Button btnUploadCoverImg;
        private System.Windows.Forms.PictureBox stegoImage;
        private System.Windows.Forms.Button btnUploadSecretImage;
        private System.Windows.Forms.Button btnCreateStegoImage;
        private System.Windows.Forms.PictureBox extractedSecretImage;
        private System.Windows.Forms.Button btnExtractSecretImage;
        private System.Windows.Forms.Button btnUploadStegoImage;
        private System.Windows.Forms.Button btnSaveExtractedImage;
    }
}

