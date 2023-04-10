using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace GUI4OpenCV.Helpers
{
    public class OpenCVHelper
    {
        /// <summary>
        /// 边缘检测
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap Canny(Bitmap bitmap, double threshold1=100, double threshold2=255, int apertureSize=3, bool L2gradient=false)
        {
            var dst = new Mat();
            Cv2.Canny(bitmap.ToMat(), dst, threshold1, threshold2, apertureSize, L2gradient);
            var t = dst.ToBitmap();
            return t;
        }

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
        /// <returns></returns>
        public static Bitmap GrayToBinary(Bitmap bitmap, double thresh = 135)
        {
            return Threshold(bitmap, ThresholdTypes.Binary, thresh);
        }

        /// <summary>
        /// Threshold
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="thresholdTypes"></param>
        /// <param name="thresh"></param>
        /// <returns></returns>
        public static Bitmap Threshold(Bitmap bitmap, ThresholdTypes thresholdTypes, double thresh = 125)
        {
            var thdDst = new Mat();
            var grayfirst = Cv2.Threshold(bitmap.ToMat(), thdDst, thresh, 255, thresholdTypes);
            var t = thdDst.ToBitmap();
            return t;
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
        public static Bitmap Blur(Bitmap bitmap)
        {
            // 均值滤波
            var blur = new Mat();
            Cv2.Blur(bitmap.ToMat(), blur, new OpenCvSharp.Size(3, 3));
            return blur.ToBitmap();
        }

        /// <summary>
        /// 中值滤波
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap MedianBlur(Bitmap bitmap)
        {
            // 中值滤波
            var median = new Mat();
            Cv2.MedianBlur(bitmap.ToMat(), median, 3);
            return median.ToBitmap();
        }

        /// <summary>
        /// 高斯滤波
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap GaussianBlur(Bitmap bitmap)
        {
            // 高斯滤波
            var gaussian = new Mat();
            Cv2.GaussianBlur(bitmap.ToMat(), gaussian, new OpenCvSharp.Size(3, 3), 0);
            return gaussian.ToBitmap();
        }

        /// <summary>
        /// 盒式滤波
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap BoxFilter(Bitmap bitmap)
        {
            // 盒式滤波
            var box = new Mat();
            Cv2.BoxFilter(bitmap.ToMat(), box, MatType.CV_8UC3, new OpenCvSharp.Size(5, 5));
            return box.ToBitmap();
        }

        /// <summary>
        /// 形态学 Open滤波
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap MorphologyEx(Bitmap bitmap)
        {
            // 形态学 Open
            var morphotoOpen = new Mat();
            Cv2.MorphologyEx(bitmap.ToMat(), morphotoOpen, MorphTypes.Open, new Mat());
            return morphotoOpen.ToBitmap();
        }

        #endregion 滤波
    }
}