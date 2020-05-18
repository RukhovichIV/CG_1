using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class MatrixFilter : Filter
    {
        protected float[,] kernel = null;

        protected MatrixFilter() { }

        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
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
            Color result = Color.FromArgb(255, Clamp((int)resR, 0, 255),
                Clamp((int)resG, 0, 255), Clamp((int)resB, 0, 255));
            return result;
        }

        protected void NormalizeKernel()
        {
            if (kernel == null)
            {
                return;
            }
            float sum = 0;
            for (int x = 0; x < kernel.GetLength(0); ++x)
            {
                for (int y = 0; y < kernel.GetLength(1); ++y)
                {
                    sum += kernel[x, y];
                }
            }
            for (int x = 0; x < kernel.GetLength(0); ++x)
            {
                for (int y = 0; y < kernel.GetLength(1); ++y)
                {
                    kernel[x, y] /= sum;
                }
            }
        }
    }
}
