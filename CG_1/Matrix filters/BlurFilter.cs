using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class BlurFilter : MatrixFilter
    {
        public BlurFilter()
        {
            kernel = new float[3, 3];
            for (int x = 0; x < 3; ++x)
            {
                for (int y = 0; y < 3; ++y)
                {
                    kernel[x, y] = 1f / 9;
                }
            }
        }
    }
}
