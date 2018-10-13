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
        public static Bitmap Transform(Bitmap img)
        {
            int w = img.Width;
            int h = img.Height;
            Bitmap cp = img;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Color c = img.GetPixel(i, j);
                    byte r = (byte)(c.R & 0xfc);
                    byte g = (byte)(c.G & 0xfc);
                    byte b = (byte)(c.B & 0xfc);

                    cp.SetPixel(i, j, Color.FromArgb(r, g, b)); 
                }
            }

            return cp;
        }
    }
}
