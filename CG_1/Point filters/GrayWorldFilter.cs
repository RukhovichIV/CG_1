using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class GrayWorldFilter : Filter
    {
        float rMult = 0f, gMult = 0f, bMult = 0f;

        protected override void DoPreprocessing(FastBitmap bmp)
        {
            for (int y = 0; y < bmp.height; ++y)
            {
                for (int x = 0; x < bmp.width; ++x)
                {
                    Color color = bmp.GetPixel(x, y);
                    rMult += color.R;
                    gMult += color.G;
                    bMult += color.B;
                }
            }
            int pixelCount = bmp.height * bmp.width;
            rMult /= pixelCount;
            gMult /= pixelCount;
            bMult /= pixelCount;
            float avg = (rMult + gMult + bMult) / 3;
            rMult = avg / rMult;
            gMult = avg / gMult;
            bMult = avg / bMult;

            /// Normalizing multipliers
            float max = rMult;
            if (gMult > max)
                max = gMult;
            if (bMult > max)
                max = bMult;
            rMult /= max;
            gMult /= max;
            bMult /= max;
        }

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            Color source = bmp.GetPixel(x, y);
            return Color.FromArgb((int)(source.R * rMult), (int)(source.G * gMult), (int)(source.B * bMult));
        }
    }
}
