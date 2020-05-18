using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class DilationFilter : MorphologyFilter
    {
        bool[,] structElem;

        public DilationFilter(bool[,] structElem)
        {
            this.structElem = InvertStructElem(structElem);
        }

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            int dxRad = structElem.GetLength(0) >> 1, dyRad = structElem.GetLength(1) >> 1;
            for (int dx = -dxRad; dx <= dxRad; ++dx)
            {
                for (int dy = -dyRad; dy <= dyRad; ++dy)
                {
                    int newX = Clamp(x + dx, 0, bmp.width - 1), newY = Clamp(y + dy, 0, bmp.height - 1);
                    if (binaryImage[newX, newY] && structElem[dx + dxRad, dy + dyRad])
                        return Color.Blue;
                }
            }
            return Color.White;
        }
    }
}
