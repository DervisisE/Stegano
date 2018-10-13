﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String imageLocation = "";
            try
            {

                OpenFileDialog ofile = new OpenFileDialog();
                ofile.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (ofile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = ofile.FileName;
                    coverImage.Image = new Bitmap(imageLocation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }

        private void btnUploadSecretImage_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {

                OpenFileDialog ofile = new OpenFileDialog();
                ofile.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (ofile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = ofile.FileName;
                    secretImage.Image = new Bitmap(imageLocation);
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
            stegoImage.Image = Transform((Bitmap)coverImage.Image, (Bitmap)secretImage.Image);
        }

        private void btnExtractSecretImage_Click(object sender, EventArgs e)
        {
            extractedSecretImage.Image = Extract((Bitmap)stegoImage.Image);
        }
    }
}
