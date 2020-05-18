using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class StampingFilter : MatrixFilter
    {
        public StampingFilter()
        {
            kernel = new float[3, 3];
            kernel[0, 1] = kernel[1, 0] = 1f;
            kernel[2, 1] = kernel[1, 2] = -1f;
        }

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            if (kernel == null)
                return bmp.GetPixel(x, y);
            x -= kernel.GetLength(0) / 2;
            y -= kernel.GetLength(1) / 2;
            float resR = 0, resG = 0, resB = 0;
            for (int dx = 0; dx < kernel.GetLength(0); ++dx)
            {
                for (int dy = 0; dy < kernel.GetLength(1); ++dy)
                {
                    int newX = Clamp(x + dx, 0, bmp.width - 1);
                    int newY = Clamp(y + dy, 0, bmp.height - 1);
                    Color color = bmp.GetPixel(newX, newY);
                    resR += color.R * kernel[dx, dy];
                    resG += color.G * kernel[dx, dy];
                    resB += color.B * kernel[dx, dy];
                }
            }
            resR = (resR + 510) / 4;
            resG = (resG + 510) / 4;
            resB = (resB + 510) / 4;
            Color result = Color.FromArgb(255, (int)resR, (int)resG, (int)resB);
            return result;
        }
    }
}
