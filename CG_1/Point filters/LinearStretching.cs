using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class LinearStretchingFilter : Filter
    {
        int rMin = 255, gMin = 255, bMin = 255, rMax = 0, gMax = 0, bMax = 0;

        protected override void DoPreprocessing(FastBitmap bmp)
        {
            for (int y = 0; y < bmp.height; ++y)
            {
                for (int x = 0; x < bmp.width; ++x)
                {
                    Color color = bmp.GetPixel(x, y);
                    if (color.R < rMin)
                        rMin = color.R;
                    if (color.R > rMax)
                        rMax = color.R;
                    if (color.G < gMin)
                        gMin = color.G;
                    if (color.G > gMax)
                        gMax = color.G;
                    if (color.B < bMin)
                        bMin = color.B;
                    if (color.B > bMax)
                        bMax = color.B;
                }
            }
        }

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            Color source = bmp.GetPixel(x, y);
            return Color.FromArgb((source.R - rMin) * 255 / (rMax - rMin),
                (source.G - gMin) * 255 / (gMax - gMin),
                (source.B - bMin) * 255 / (bMax - bMin));
        }
    }
}
