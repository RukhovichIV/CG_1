using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    abstract class Filter
    {
        protected abstract Color CalculateNewPixelColor(FastBitmap bmp, int x, int y);

        protected virtual void DoPreprocessing(FastBitmap bmp)
        {
            return;
        }

        public FastBitmap ProcessImage(FastBitmap bmp, BackgroundWorker worker)
        {
            DoPreprocessing(bmp);
            FastBitmap result = new FastBitmap(bmp.width, bmp.height);
            for (int y = 0; y < bmp.height; ++y)
            {
                worker.ReportProgress((int)(y * 100f / bmp.height));
                if (worker.CancellationPending)
                    return null;
                for (int x = 0; x < bmp.width; ++x)
                {
                    result.SetPixel(x, y, CalculateNewPixelColor(bmp, x, y));
                }
            }
            return result;
        }

        protected int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            else if (max < value)
                return max;
            return value;
        }
    }
}
