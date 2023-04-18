using GUI4OpenCV.ConfigWindows;
using GUI4OpenCV.Extensions;
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
        public static Bitmap Salt(Bitmap bitmap, Color noiseColor, int noise = 25000)
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

        /// <summary>
        /// 高斯噪声
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="mean">均值</param>
        /// <param name="stdDev">标准差</param>
        /// <returns></returns>
        public static Bitmap Gaussian(Bitmap bitmap, double mean=0, double stdDev=10)
        {
            using var src = bitmap.ToMat();
            var noise = new Mat(src.Size(), MatType.CV_64FC3);// 灰度图像使用MatType.CV_64F
            Cv2.Randn(noise, mean, stdDev);
            noise = noise.Reshape(3, src.Rows);
            using var result = new Mat();
            Cv2.Add(src, noise, result, new Mat(), MatType.CV_8UC3);// 灰度图像使用MatType.CV_8U
            return result.ToBitmap();
        }

        /// <summary>
        /// 泊松噪声
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="lambda">均值</param>
        /// <returns></returns>
        public static Bitmap Poisson(Bitmap bitmap, double lambda = 10)
        {
            using var src = bitmap.ToMat();
            var noise=new Mat(src.Size(), MatType.CV_64FC3); // 灰度图像使用MatType.CV_64F
            // 生成一个均值为0，标准差为1的高斯分布
            Cv2.Randn(noise, 0, 1);
            noise = noise.Reshape(3, src.Rows);
            using var result = new Mat();
            // 转换成均值为lambda的泊松分布
            Cv2.Exp(lambda * noise, noise);
            // 缩放结果在0-255以内
            Cv2.Multiply(noise, src, result, 1.0/255, MatType.CV_8UC3); // 灰度图像使用MatType.CV_8U
            return result.ToBitmap();
        }
    }
}
