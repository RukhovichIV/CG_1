using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class GaussianFilter : MatrixFilter
    {
        public GaussianFilter(int radius)
        {
            float std = 0;
            for (int i = 1; i <= radius; ++i)
            {
                std += i * i;
            }
            std *= 2f / (2 * radius + 1);
            std = (float)Math.Sqrt(std);
            float divider = std * (float)Math.Sqrt(2 * Math.PI);

            int kSize = 2 * radius + 1;
            kernel = new float[kSize, kSize];
            for (int x = 0; x < kSize; ++x)
            {
                for (int y = 0; y < kSize; ++y)
                {
                    int dx = radius - x, dy = radius - y;
                    kernel[x, y] = (float)Math.Exp(-(dx * dx + dy * dy) / (2 * std * std)) / divider;
                }
            }
            NormalizeKernel();
        }
    }
}
