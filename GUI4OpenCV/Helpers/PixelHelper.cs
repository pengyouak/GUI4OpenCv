using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class PixelHelper
    {
        public static Vec3b ReadPix(Bitmap bitmap, int x, int y)
        {
            using Mat src = bitmap.ToMat();
            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {  
                    //B: color.Item0, G: color.Item1, R: color.Item2
                    if (x == i && y == j) return src.Get<Vec3b>(j, i);
                }
            }

            return new Vec3b(0, 0, 0);
        }

        public static Color ReadPicColor(Bitmap bitmap, int x, int y)
        {
            var vec = ReadPix(bitmap, x, y);
            return Color.FromArgb(vec.Item0, vec.Item1, vec.Item2);
        }

        public static Bitmap WritePix(Bitmap bitmap, int x, int y, byte b, byte g, byte r)
        {
            using Mat src = bitmap.ToMat();
            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {
                    if (i < 10)
                    {
                        src.Set(j, i, new Vec3b(b, g, r));
                    }
                }
            }
            return src.ToBitmap();
        }
    }
}
