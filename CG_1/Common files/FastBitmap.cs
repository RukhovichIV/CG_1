using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CG_1
{
    public class FastBitmap : IDisposable
    {
        public Bitmap image { get; private set; }
        public byte[] bits { get; private set; }
        public bool disposed { get; private set; }
        public int height { get; private set; }
        public int width { get; private set; }

        protected GCHandle bitsHandle { get; private set; }

        private FastBitmap() { }

        public FastBitmap(int width, int height)
        {
            this.width = width;
            this.height = height;
            bits = new byte[(width * height) << 2];
            bitsHandle = GCHandle.Alloc(bits, GCHandleType.Pinned);
            image = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, bitsHandle.AddrOfPinnedObject());
        }

        public FastBitmap(string fileName)
        {
            Bitmap bmp = new Bitmap(fileName);
            width = bmp.Width;
            height = bmp.Height;
            bits = new byte[(width * height) << 2];
            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    SetPixel(x, y, bmp.GetPixel(x, y));
                }
            }
            bitsHandle = GCHandle.Alloc(bits, GCHandleType.Pinned);
            image = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, bitsHandle.AddrOfPinnedObject());
        }

        public void SetPixel(int x, int y, Color color)
        {
            int index = (x + (y * width)) << 2;
            bits[index] = color.B;
            bits[++index] = color.G;
            bits[++index] = color.R;
            bits[++index] = color.A;
        }

        public Color GetPixel(int x, int y)
        {
            int index = (x + (y * width)) << 2;
            return Color.FromArgb(bits[index + 3], bits[index + 2], bits[index + 1], bits[index]);
        }

        public void Dispose()
        {
            if (disposed) return;
            disposed = true;
            image.Dispose();
            bitsHandle.Free();
        }
    }
}
