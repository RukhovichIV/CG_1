using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    class MorphologyFilter : Filter
    {

        protected bool[,] binaryImage;

        protected override void DoPreprocessing(FastBitmap bmp)
        {
            binaryImage = new bool[bmp.width, bmp.height];
            for (int x = 0; x < bmp.width; ++x)
            {
                for (int y = 0; y < bmp.height; ++y)
                {
                    Color col = bmp.GetPixel(x, y);
                    binaryImage[x, y] = col.R <= 127 && col.G <= 127 && col.B > 127;
                }
            }
        }

        protected override Color CalculateNewPixelColor(FastBitmap bmp, int x, int y)
        {
            throw new NotImplementedException();
        }

        protected bool[,] InvertStructElem(bool[,] elem)
        {
            bool[,] result = new bool[elem.GetLength(0), elem.GetLength(1)];
            for (int x = 0; x < elem.GetLength(0); ++x)
            {
                for (int y = 0; y < elem.GetLength(1); ++y)
                {
                    result[x, y] = elem[elem.GetLength(0) - 1 - x, elem.GetLength(1) - 1 - y];
                }
            }
            return result;
        }
    }
}
