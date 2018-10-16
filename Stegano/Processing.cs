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
                byte rc1 = (byte)((c1.R & 0xfc) | ((byte)(wS >> 10) & 0x3));
                byte gc1 = (byte)((c1.G & 0xfc) | ((byte)(wS >> 8) & 0x3));
                byte bc1 = (byte)((c1.B & 0xfc) | ((byte)(wS >> 6) & 0x3));

                stImg.SetPixel(0, 0, Color.FromArgb(rc1, gc1, bc1));

                Color c2 = cImg.GetPixel(0, 1);
                byte rc2 = (byte)((c2.R & 0xfc) | ((byte)(wS >> 4) & 0x3));
                byte gc2 = (byte)((c2.G & 0xfc) | ((byte)(wS >> 2) & 0x3));
                byte bc2 = (byte)((c2.B & 0xfc) | (byte)(wS & 0x3));

                stImg.SetPixel(0, 1, Color.FromArgb(rc2, gc2, bc2));

                Color c3 = cImg.GetPixel(0, 2);
                byte rc3 = (byte)((c3.R & 0xfc) | ((byte)(hS >> 10) & 0x3));
                byte gc3 = (byte)((c3.G & 0xfc) | ((byte)(hS >> 8) & 0x3));
                byte bc3 = (byte)((c3.B & 0xfc) | ((byte)(hS >> 6) & 0x3));

                stImg.SetPixel(0, 2, Color.FromArgb(rc3, gc3, bc3));

                Color c4 = cImg.GetPixel(0, 3);
                byte rc4 = (byte)((c4.R & 0xfc) | ((byte)(hS >> 4) & 0x3));
                byte gc4 = (byte)((c4.G & 0xfc) | ((byte)(hS >> 2) & 0x3));
                byte bc4 = (byte)((c4.B & 0xfc) | (byte)(hS & 0x3));

                stImg.SetPixel(0, 3, Color.FromArgb(255, rc4, gc4, bc4));
            }


            int m = 0;
            int n = 0;
            for (int i=0; i < wC; i++)
            {
                for (int j = 0; j+1 < hC; j+=2)
                {
                    if (i == 0 && j < 4)
                    {
                        continue;
                    }
                    Color cC1 = cImg.GetPixel(i, j);
                    Color cC2 = cImg.GetPixel(i, j+1);

                    if (m < wS)
                    {
                        Color cS = compSecretImg.GetPixel(m, n);

                        byte rC1 = (byte)(cC1.R & 0xfc);
                        byte gC1 = (byte)(cC1.G & 0xfc);
                        byte bC1 = (byte)(cC1.B & 0xfc);

                        byte rC2 = (byte)(cC2.R & 0xfc);
                        byte gC2 = (byte)(cC2.G & 0xfc);
                        byte bC2 = (byte)(cC2.B & 0xfc);

                        byte rS1 = (byte)((cS.R >> 6) & 0x3);
                        byte gS1 = (byte)((cS.G >> 6) & 0x3);
                        byte bS1 = (byte)((cS.B >> 6) & 0x3);

                        byte rS2 = (byte)((cS.R >> 4) & 0x3);
                        byte gS2 = (byte)((cS.G >> 4) & 0x3);
                        byte bS2 = (byte)((cS.B >> 4) & 0x3);

                        rC1 = (byte)(rC1 | rS1);
                        gC1 = (byte)(gC1 | gS1);
                        bC1 = (byte)(bC1 | bS1);

                        rC2 = (byte)(rC2 | rS2);
                        gC2 = (byte)(gC2 | gS2);
                        bC2 = (byte)(bC2 | bS2);

                        stImg.SetPixel(i, j, Color.FromArgb(255, rC1, gC1, bC1));
                        stImg.SetPixel(i, j + 1, Color.FromArgb(255, rC2, gC2, bC2));
                    }
                    n++;
                    if (n >= hS)
                    {
                        m++;
                        n = 0;

                    }
                }
            }
            return stImg;
        }

        public static Bitmap Extract(Bitmap sImg)
        {
            int wC = sImg.Width;
            int hC = sImg.Height;

            Color c1 = sImg.GetPixel(0, 0);
            Color c2 = sImg.GetPixel(0, 1);
            Color c3 = sImg.GetPixel(0, 2);
            Color c4 = sImg.GetPixel(0, 3);

            int wS = ((byte)(c1.R << 6) << 4) | ((byte)(c1.G << 6) << 2) | ((byte)(c1.B << 6)) |        //Getting SecretImage's width and height
                ((byte)(c2.R << 6) >> 2) | ((byte)(c2.G << 6) >> 4) | ((byte)(c2.B << 6) >> 6);
            int hS = ((byte)(c3.R << 6) << 4) | ((byte)(c3.G << 6) << 2) | ((byte)(c3.B << 6)) |
                ((byte)(c4.R << 6) >> 2) | ((byte)(c4.G << 6) >> 4) | ((byte)(c4.B << 6) >> 6);
            Bitmap eImg = new Bitmap(sImg, new Size(wS, hS));
            int m = 0;
            int n = 0;
            for (int i = 0; i < wC; i++)
            {
                for (int j = 0; j + 1 < hC; j+=2)
                {
                    if (i == 0 && j < 4)
                    {
                        continue;
                    }
                    Color cS1 = sImg.GetPixel(i, j);
                    Color cS2 = sImg.GetPixel(i, j + 1);

                    byte rS = (byte)((byte)(cS1.R << 6) | ((byte)(cS2.R << 6) >> 2));
                    byte gS = (byte)((byte)(cS1.G << 6) | ((byte)(cS2.G << 6) >> 2));
                    byte bS = (byte)((byte)(cS1.B << 6) | ((byte)(cS2.B << 6) >> 2));

                    
                    if (m < wS)
                    {
                        eImg.SetPixel(m, n, Color.FromArgb(255, rS, gS, bS));
                    }
                    n++;
                    if (n >= hS)
                    {
                        m++;
                        n = 0;

                    }
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
