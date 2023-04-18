using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class NoiseHelper
    {
        /// <summary>
        /// 椒盐噪声
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="noiseColor">噪点颜色</param>
        /// <param name="noise">噪点数</param>
        /// <returns></returns>
        public static Bitmap Salt(Bitmap bitmap, Color noiseColor, int noise=25000)
        {
            using Mat src = bitmap.ToMat();
            Random random = new Random();
            for (int i = 0; i < noise; i++)
            {
                int row = random.Next(src.Rows);
                int col = random.Next(src.Cols);

                Vec3b white = new Vec3b(noiseColor.B, noiseColor.G, noiseColor.R);
                src.Set(row, col, white);
            }
            return src.ToBitmap();
        }
    }
}
