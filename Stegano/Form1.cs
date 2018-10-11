using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            /* 
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
            */ 

        }
    }
}
