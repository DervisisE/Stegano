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
            Bitmap stImg = cImg;
            /*int ws = sImg.Width;
            int hs = sImg.Height;
            float ratioS = (float)ws / hs;
            int cNumP = wc * hc;
            int sNumP = ws * hs;
            float ratioStoC = (float)cNumP / (2 * sNumP);
            float cCapBit = 6 * cNumP-24;
            float sNumBit = sNumP * 12;
            float nws = ws * (cCapBit / sNumBit);
            float nhs = hs * (cCapBit / sNumBit);

            Bitmap b = new Bitmap(cImg, new Size((int)nws, (int)nhs));
            */

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

                    stImg.SetPixel(i, j, Color.FromArgb(rc, gc, bc));

                }
            }
            //Bitmap b = new Bitmap(stImg, new Size(100, 100));
            return stImg;
            
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
