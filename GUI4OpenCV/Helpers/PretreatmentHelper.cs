using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace GUI4OpenCV.Helpers
{
    public class PretreatmentHelper
    {

        /// <summary>
        /// 灰度
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap RgbToGray(Bitmap bitmap)
        {
            using var clrDst = new Mat();
            Cv2.CvtColor(bitmap.ToMat(), clrDst, ColorConversionCodes.RGB2GRAY);
            return clrDst.ToBitmap();
        }

        /// <summary>
        /// 灰度均衡
        /// </summary>
        /// <returns></returns>
        public static Bitmap EqualizeHist(Bitmap src)
        {
            using Mat output = new Mat();
            Cv2.CvtColor(src.ToMat(), output, ColorConversionCodes.BGR2GRAY);
            Cv2.EqualizeHist(output, output);
            return output.ToBitmap();
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
            // 转换为灰度图像
            using Mat gray = new Mat();
            Cv2.CvtColor(bitmap.ToMat(), gray, ColorConversionCodes.RGB2GRAY);

            // 对图像进行二值化处理
            using Mat binary = new Mat();
            Cv2.Threshold(gray, binary, thresh, maxval, ThresholdTypes.Binary | ThresholdTypes.Otsu);

            return binary.ToBitmap();
        }

        /// <summary>
        /// 膨胀
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Bitmap Structure(Bitmap bitmap, int width = 2, int height=2)
        {
            using var element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(width, height));
            using var dltDst = new Mat();
            Cv2.Dilate(bitmap.ToMat(), dltDst, element);
            var t = dltDst.ToBitmap();
            return t;
        }

        /// <summary>
        /// HSV
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap HSV(Bitmap bitmap)
        {
            using Mat src = bitmap.ToMat();
            using Mat result = src.CvtColor(ColorConversionCodes.BGR2HSV);
            return result.ToBitmap();
        }

        /// <summary>
        /// HSV
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap Revert(Bitmap bitmap)
        {
            using Mat src = bitmap.ToMat();
            using Mat result = new Mat();
            Cv2.BitwiseNot(src, result);
            return result.ToBitmap();
        }
    }
}