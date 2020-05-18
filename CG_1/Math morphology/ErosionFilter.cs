using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class ErosionFilter : MorphologyFilter
    {
        bool[,] structElem;

        public ErosionFilter(bool[,] structElem)
        {
            this.structElem = structElem;
        }

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            int dxRad = structElem.GetLength(0) >> 1, dyRad = structElem.GetLength(1) >> 1;
            for (int dx = -dxRad; dx <= dxRad; ++dx)
            {
                for (int dy = -dyRad; dy <= dyRad; ++dy)
                {
                    int newX = Clamp(x + dx, 0, bmp.width - 1), newY = Clamp(y + dy, 0, bmp.height - 1);
                    if (structElem[dx + dxRad, dy + dyRad] && !binaryImage[newX, newY])
                        return Color.White;
                }
            }
            return Color.Blue;
        }
    }
}
