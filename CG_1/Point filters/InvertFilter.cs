using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class InvertFilter : Filter
    {
        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            Color source = bmp.GetPixel(x, y);
            return Color.FromArgb(255 - source.R, 255 - source.G, 255 - source.B);
        }
    }
}
