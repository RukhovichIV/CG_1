using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class GlassFilter : Filter
    {
        Random gen = new Random();

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            int newX = x + (int)((gen.NextDouble() - 0.5) * 40);
            int newY = y + (int)((gen.NextDouble() - 0.5) * 40);
            return bmp.GetPixel(Clamp(newX, 0, bmp.width - 1), Clamp(newY, 0, bmp.height - 1));
        }
    }
}
