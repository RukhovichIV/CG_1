using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class RotateFilter : Filter
    {
        int xBase, yBase;
        float angle;

        public RotateFilter(int angle)
        {
            this.angle = angle / 180f * (float)Math.PI;
        }

        protected override void DoPreprocessing(FastBitmap bmp)
        {
            xBase = bmp.width / 2;
            yBase = bmp.height / 2;
        }

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {

            int newX = (int)((x - xBase) * Math.Cos(angle) - (y - yBase) * Math.Sin(angle)) + xBase;
            int newY = (int)((x - xBase) * Math.Sin(angle) + (y - yBase) * Math.Cos(angle)) + yBase;
            if (Clamp(newX, 0, bmp.width - 1) != newX || Clamp(newY, 0, bmp.height - 1) != newY)
            {
                return Color.Black;
            }
            return bmp.GetPixel(newX, newY);
        }
    }
}
