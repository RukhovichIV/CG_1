using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class MorphGradFilter : MorphologyFilter
    {
        bool[,] structElem, invertedElem;

        public MorphGradFilter(bool[,] structElem)
        {
            this.structElem = structElem;
            invertedElem = InvertStructElem(structElem);
        }

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            bool dilate = Dilate(bmp, x, y);
            bool erode = Erode(bmp, x, y);
            if (dilate && !erode)
                return Color.Blue;
            else
                return Color.White;
        }

        private bool Dilate(FastBitmap bmp, int x, int y)
        {
            int dxRad = invertedElem.GetLength(0) >> 1, dyRad = invertedElem.GetLength(1) >> 1;
            for (int dx = -dxRad; dx <= dxRad; ++dx)
            {
                for (int dy = -dyRad; dy <= dyRad; ++dy)
                {
                    int newX = Clamp(x + dx, 0, bmp.width - 1), newY = Clamp(y + dy, 0, bmp.height - 1);
                    if (binaryImage[newX, newY] && invertedElem[dx + dxRad, dy + dyRad])
                        return true;
                }
            }
            return false;
        }

        private bool Erode(FastBitmap bmp, int x, int y)
        {
            int dxRad = structElem.GetLength(0) >> 1, dyRad = structElem.GetLength(1) >> 1;
            for (int dx = -dxRad; dx <= dxRad; ++dx)
            {
                for (int dy = -dyRad; dy <= dyRad; ++dy)
                {
                    int newX = Clamp(x + dx, 0, bmp.width - 1), newY = Clamp(y + dy, 0, bmp.height - 1);
                    if (structElem[dx + dxRad, dy + dyRad] && !binaryImage[newX, newY])
                        return false;
                }
            }
            return true;
        }
    }
}
