using OpenCvSharp.Extensions;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class FilterHelper
    {
        #region 滤波

        /// <summary>
        /// 均值滤波
        /// </summary>
        /// <returns></returns>
        public static Bitmap Blur(Bitmap bitmap, int width = 3, int heigth = 3)
        {
            // 均值滤波
            var blur = new Mat();
            Cv2.Blur(bitmap.ToMat(), blur, new OpenCvSharp.Size(width, heigth));
            return blur.ToBitmap();
        }

        /// <summary>
        /// 中值滤波
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap MedianBlur(Bitmap bitmap, int ksize = 3)
        {
            // 中值滤波
            var median = new Mat();
            Cv2.MedianBlur(bitmap.ToMat(), median, ksize);
            return median.ToBitmap();
        }

        /// <summary>
        /// 高斯双边滤波
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap BilateralFilter(Bitmap bitmap, int d = 15, double sigmaColor = 120, double sigmaSpace = 10)
        {
            var gaussian = new Mat();
            Cv2.BilateralFilter(bitmap.ToMat(), gaussian, d, sigmaColor, sigmaSpace, BorderTypes.Default);
            return gaussian.ToBitmap();
        }

        /// <summary>
        /// 模糊
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap Opaque(Bitmap bitmap, int ksize = 15)
        {
            using Mat kernal = Mat.Ones(new OpenCvSharp.Size(ksize, ksize), MatType.CV_32F) / (float)(ksize * ksize);
            var opaque = new Mat();
            Cv2.Filter2D(bitmap.ToMat(), opaque, -1, kernal, new OpenCvSharp.Point(-1, -1), 0.0, BorderTypes.Default);
            return opaque.ToBitmap();
        }

        /// <summary>
        /// 高斯滤波
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap GaussianBlur(Bitmap bitmap, int ksize = 3, double sigmaX = 0)
        {
            // 高斯滤波
            var gaussian = new Mat();
            Cv2.GaussianBlur(bitmap.ToMat(), gaussian, new OpenCvSharp.Size(ksize, ksize), sigmaX);
            return gaussian.ToBitmap();
        }

        /// <summary>
        /// 盒式滤波
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap BoxFilter(Bitmap bitmap, int ksize = 5)
        {
            // 盒式滤波
            var box = new Mat();
            Cv2.BoxFilter(bitmap.ToMat(), box, MatType.CV_8UC3, new OpenCvSharp.Size(ksize, ksize));
            return box.ToBitmap();
        }

        /// <summary>
        /// 形态学 Open滤波
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="morphTypes"></param>
        /// <returns></returns>
        public static Bitmap MorphologyEx(Bitmap bitmap, MorphTypes morphTypes = MorphTypes.Open)
        {
            // 形态学 Open
            var morph = new Mat();
            Cv2.MorphologyEx(bitmap.ToMat(), morph, morphTypes, new Mat(), new OpenCvSharp.Point(-1, -1), 1, BorderTypes.Default);
            return morph.ToBitmap();
        }

        #endregion 滤波
    }
}
