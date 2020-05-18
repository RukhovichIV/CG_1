using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class GlowingEdgesFilter : MatrixFilter
    {
        public GlowingEdgesFilter()
        {
            kernel = new float[3, 3];
            kernel[0, 0] = kernel[0, 2] = 3;
            kernel[0, 1] = 10;
            kernel[2, 0] = kernel[2, 2] = -3;
            kernel[2, 1] = -10;
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
            Color result;
            if (resR > resG)
            {
                if (resR > resB)
                    result = Color.FromArgb(255, Clamp((int)resR, 0, 255), 0, 0);
                else
                    result = Color.FromArgb(255, 0, 0, Clamp((int)resB, 0, 255));
            }
            else
            {
                if (resG > resB)
                    result = Color.FromArgb(255, 0, Clamp((int)resG, 0, 255), 0);
                else
                    result = Color.FromArgb(255, 0, 0, Clamp((int)resB, 0, 255));
            }

            return result;
        }
    }
}
