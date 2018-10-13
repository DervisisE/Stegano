using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stegano
{
    class Processing
    {
        public Processing()
        {

        }
        public static Bitmap Transform(Bitmap cImg,Bitmap sImg)
        {
            int wc = cImg.Width;
            int hc = cImg.Height;
            Bitmap stego = cImg;
            for (int i = 0; i < wc; i++)
            {
                for (int j = 0; j < hc; j++)
                {
                    Color cc = cImg.GetPixel(i, j);
                    Color cs = sImg.GetPixel(i, j);
                    byte rc = (byte)(cc.R & 0xfc);
                    byte gc = (byte)(cc.G & 0xfc);
                    byte bc = (byte)(cc.B & 0xfc);

                    byte rs = (byte)((cs.R >> 6) & 0x3);
                    byte gs = (byte)((cs.G >> 6) & 0x3);
                    byte bs = (byte)((cs.B >> 6) & 0x3);

                    rc = (byte)(rc | rs);
                    gc = (byte)(gc | gs);
                    bc = (byte)(bc | bs);

                    stego.SetPixel(i, j, Color.FromArgb(rc, gc, bc)); 

                }
            }

            return stego;
        }
        public static Bitmap Extract(Bitmap sImg)
        {
            int w = sImg.Width;
            int h = sImg.Height;
            Bitmap eImg = sImg;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Color cs = sImg.GetPixel(i, j);
                    byte rs = (byte)(cs.R << 6);
                    byte gs = (byte)(cs.G << 6);
                    byte bs = (byte)(cs.B << 6);
                    eImg.SetPixel(i, j, Color.FromArgb(rs, gs, bs));
                }
            }
            return eImg;
        }
    }
}
