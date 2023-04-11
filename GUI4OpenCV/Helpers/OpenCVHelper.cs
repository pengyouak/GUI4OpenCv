using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace GUI4OpenCV.Helpers
{
    public class OpenCVHelper
    {
        /// <summary>
        /// 放大
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Bitmap Shrink(Bitmap bitmap, double p)
        {
            if (p <= 0) return bitmap;

            var dst = new Mat();
            Cv2.Resize(bitmap.ToMat(), dst, new OpenCvSharp.Size(bitmap.Width * p, bitmap.Height * p), interpolation: InterpolationFlags.Cubic);
            var t = dst.ToBitmap();
            return t;
        }

        /// <summary>
        /// 灰度
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap RgbToGray(Bitmap bitmap)
        {
            var clrDst = new Mat();
            Cv2.CvtColor(bitmap.ToMat(), clrDst, ColorConversionCodes.RGB2GRAY);
            var t = clrDst.ToBitmap();
            return t;
        }

        /// <summary>
        /// 二值
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="thresh"></param>
        /// <param name="maxval"></param>
        /// <returns></returns>
        public static Bitmap GrayToBinary(Bitmap bitmap, double thresh = 135, double maxval=255)
        {
            var thdDst = new Mat();
            Cv2.Threshold(bitmap.ToMat(), thdDst, thresh, maxval, ThresholdTypes.Binary);
            return thdDst.ToBitmap();
        }

        /// <summary>
        /// 膨胀
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Bitmap Structure(Bitmap bitmap, int p = 2)
        {
            var element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(p, p));
            var dltDst = new Mat();
            Cv2.Dilate(bitmap.ToMat(), dltDst, element);
            var t = dltDst.ToBitmap();
            return t;
        }

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
        public static Bitmap MorphologyEx(Bitmap bitmap, MorphTypes morphTypes= MorphTypes.Open)
        {
            // 形态学 Open
            var morph = new Mat();   
            Cv2.MorphologyEx(bitmap.ToMat(), morph, morphTypes, new Mat(), new OpenCvSharp.Point(-1,-1), 1, BorderTypes.Default);
            return morph.ToBitmap();
        }

        #endregion 滤波
    }
}