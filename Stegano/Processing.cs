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
            int wC = cImg.Width;
            int hC = cImg.Height;
            

            Bitmap compSecretImg = CompressSecretImage(cImg, sImg);
            int wS = compSecretImg.Width;
            int hS = compSecretImg.Height;
            Bitmap stImg = cImg;
            /// --METADATA CREATION--
            /// Writing compressedSecretImage's width,height in the first 4 pixels of stegoImage 
            /// Maximum compressedSecretImg resolution 4095*4095 
            /// ( 2bits pes r,b,g in pixel) * 4pixels = 24bits dedicated 
            {       
                Color c1 = cImg.GetPixel(0, 0);
                byte rc1 = (byte)((c1.R & 0xfc) | ((wS >> 10) & 0x3));
                byte gc1 = (byte)((c1.G & 0xfc) | ((wS >> 8) & 0x3));
                byte bc1 = (byte)((c1.B & 0xfc) | ((wS >> 6) & 0x3));

                stImg.SetPixel(0, 0, Color.FromArgb(rc1, gc1, bc1));

                Color c2 = cImg.GetPixel(0, 1);
                byte rc2 = (byte)((c2.R & 0xfc) | ((wS >> 4) & 0x3));
                byte gc2 = (byte)((c2.G & 0xfc) | ((wS >> 2) & 0x3));
                byte bc2 = (byte)((c2.B & 0xfc) | (wS & 0x3));

                stImg.SetPixel(0, 1, Color.FromArgb(rc2, gc2, bc2));

                Color c3 = cImg.GetPixel(0, 2);
                byte rc3 = (byte)((c3.R & 0xfc) | ((hS >> 10) & 0x3));
                byte gc3 = (byte)((c3.G & 0xfc) | ((hS >> 8) & 0x3));
                byte bc3 = (byte)((c3.B & 0xfc) | ((hS >> 6) & 0x3));

                stImg.SetPixel(0, 2, Color.FromArgb(rc3, gc3, bc3));

                Color c4 = cImg.GetPixel(0, 3);
                byte rc4 = (byte)((c4.R & 0xfc) | ((hS >> 4) & 0x3));
                byte gc4 = (byte)((c4.G & 0xfc) | ((hS >> 2) & 0x3));
                byte bc4 = (byte)((c4.B & 0xfc) | (hS & 0x3));

                stImg.SetPixel(0, 3, Color.FromArgb(rc4, gc4, bc4));
            }



            /*
            for (int i = 0; i < wC; i++)
            {
                for (int j = 0; j < hC; j++)
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
            }*/
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
                    Color cS = sImg.GetPixel(i, j);
                    byte rS = (byte)(cS.R << 6);
                    byte gS = (byte)(cS.G << 6);
                    byte bS = (byte)(cS.B << 6);
                    eImg.SetPixel(i, j, Color.FromArgb(rS, gS, bS));
                }
            }
            return eImg;
        }
        public static Bitmap CompressSecretImage(Bitmap cImg, Bitmap sImg)
        {
            int wC = cImg.Width;
            int hC = cImg.Height;
            int wS = sImg.Width;
            int hS = sImg.Height;
            float ratioS = (float)wS / hS;
            int cNumP = wC * hC;                                        
            float cCapBit = 6 * cNumP - 24;                             //Calculating CoverImage's Capacity in Bits
            double nWS = Math.Sqrt((cCapBit * ratioS) / 12);            //New width for compressed Secret Image
            double nHS = nWS / ratioS;                                  //New height for compressed Secret Image

            Bitmap b = new Bitmap(sImg, new Size((int)nWS, (int)nHS));  //Resize SecretImage resolution to fit in CoverImage
            return b;
        }
    }
}
