using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class PerfectReflectorFilter : Filter
    {
        float rMult = 0f, gMult = 0f, bMult = 0f;

        protected override void DoPreprocessing(FastBitmap bmp)
        {
            for (int y = 0; y < bmp.height; ++y)
            {
                for (int x = 0; x < bmp.width; ++x)
                {
                    Color color = bmp.GetPixel(x, y);
                    if (rMult < color.R)
                        rMult = color.R;
                    if (gMult < color.G)
                        gMult = color.G;
                    if (bMult < color.B)
                        bMult = color.B;
                }
            }
            rMult = 255 / rMult;
            gMult = 255 / gMult;
            bMult = 255 / bMult;
        }

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            Color source = bmp.GetPixel(x, y);
            return Color.FromArgb((int)(source.R * rMult), (int)(source.G * gMult), (int)(source.B * bMult));
        }
    }
}
