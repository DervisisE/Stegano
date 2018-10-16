using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static Stegano.Processing;


namespace Stegano
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String coverImageLocation = "";
        private String secretImageLocation = "";
        private String stegoImageLocation = "";
        private String extractedImageLocation = "";
        private Bitmap cover;
        private Bitmap secret;
        private Bitmap stego;
        private Bitmap extracted;

        private void btnUploadCoverImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog coverImageFile = new OpenFileDialog();
                coverImageFile.Filter = "PNG files(*.png)|*.png|All Files(*.*)|*.* | jpg files(*.jpg)|*.jpg";

                if (coverImageFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    coverImageLocation = coverImageFile.FileName;
                    cover = new Bitmap(coverImageLocation);
                    coverImage.Image = cover;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUploadSecretImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofile = new OpenFileDialog();
                ofile.Filter = "PNG files(*.png)|*.png|All Files(*.*)|*.* | jpg files(*.jpg)|*.jpg";

                if (ofile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    secretImageLocation = ofile.FileName;
                    secret = new Bitmap(secretImageLocation);
                    secretImage.Image = secret;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateStegoImage_Click(object sender, EventArgs e)
        {
            //TRY CATCH
            stego = Transform((Bitmap)coverImage.Image, (Bitmap)secretImage.Image);
            stegoImage.Image = stego;
        }

        private void btnExtractSecretImage_Click(object sender, EventArgs e)
        {
            extracted = Extract(stego);
            extractedSecretImage.Image = extracted;
        }

        private void btnSaveStegoImage_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PNG files(*.png)|*.png| jpg files(*.jpg)|*.jpg| All Files(*.*)|*.*";

                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    stegoImageLocation = save.FileName;
                }

                Bitmap b = new Bitmap(stego);

                b.Save(stegoImageLocation, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUploadStegoImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofile = new OpenFileDialog();
                ofile.Filter = "PNG files(*.png)|*.png| jpg files(*.jpg)|*.jpg| All Files(*.*)|*.*";

                if (ofile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    stegoImageLocation = ofile.FileName;
                    stego = new Bitmap(stegoImageLocation);
                    stegoImage.Image = stego;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveExtractedImage_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PNG files(*.png)|*.png| jpg files(*.jpg)|*.jpg| All Files(*.*)|*.*";

                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    extractedImageLocation = save.FileName;
                }

                Bitmap b = new Bitmap(extracted);

                b.Save(extractedImageLocation, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
