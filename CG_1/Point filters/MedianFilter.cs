using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class MedianFilter : Filter
    {
        byte[] colArr;
        int radius, size;

        public MedianFilter(int radius)
        {
            this.radius = radius;
            size = 2 * radius + 1;
            colArr = new byte[size * size];
        }

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            for (int dx = -radius; dx <= radius; ++dx)
            {
                for (int dy = -radius; dy <= radius; ++dy)
                {
                    colArr[(dx + radius) * size + dy + radius] = bmp.GetPixel(Clamp(x + dx, 0, bmp.width-1), Clamp(y + dy, 0, bmp.height-1)).R;
                }
            }
            byte medianCol = FindMedian();
            return Color.FromArgb(medianCol, medianCol, medianCol);
        }

        private byte FindMedian()
        {
            int l = 0, r = size * size - 1, nthPos = r >> 1;
            while (l + 1 < r)
            {
                int rit = r, lit = l;
                int baseInd = (l + r) >> 1;
                while (lit < rit)
                {
                    while (rit > baseInd && colArr[rit] >= colArr[baseInd])
                        --rit;
                    while (colArr[lit] < colArr[baseInd])
                        ++lit;
                    byte tmp = colArr[lit];
                    colArr[lit] = colArr[rit];
                    colArr[rit] = tmp;
                    if (rit == baseInd)
                        break;
                    --rit;
                }
                if (rit > nthPos)
                    r = rit;
                else
                    l = rit;
            }
            return colArr[l];
        }
    }
}
