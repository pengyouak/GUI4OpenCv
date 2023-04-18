﻿using OpenCvSharp;
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
        /// 灰度直方图
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static Bitmap GrayHistogram(Bitmap src)
        {
            Mat[] bgr_planes = new Mat[3];
            Cv2.Split(src.ToMat(), out bgr_planes);

            int[] histSize = { 256 };
            Rangef[] histRange = { new Rangef(0, 256) }; //the upper boundary is exclusive               

            bool uniform = true, accumulate = false;
            using Mat b_hist = new Mat();
            using Mat g_hist = new Mat();
            using Mat r_hist = new Mat();

            Cv2.CalcHist(bgr_planes, new int[] { 0 }, null, b_hist, 1, histSize, histRange, uniform, accumulate);
            Cv2.CalcHist(bgr_planes, new int[] { 1 }, null, g_hist, 1, histSize, histRange, uniform, accumulate);
            Cv2.CalcHist(bgr_planes, new int[] { 2 }, null, r_hist, 1, histSize, histRange, uniform, accumulate);

            int hist_w = src.Width, hist_h = src.Height;
            int bin_w = (int)Math.Round((double)hist_w / histSize[0]);

            using Mat histImage = new Mat(hist_h, hist_w, MatType.CV_8UC3, new Scalar(0, 0, 0));

            Cv2.Normalize(b_hist, b_hist, 0, histImage.Rows, NormTypes.MinMax, -1, null);
            Cv2.Normalize(g_hist, g_hist, 0, histImage.Rows, NormTypes.MinMax, -1, null);
            Cv2.Normalize(r_hist, r_hist, 0, histImage.Rows, NormTypes.MinMax, -1, null);

            for (int i = 1; i < histSize[0]; i++)
            {
                Cv2.Line(histImage,
                        new OpenCvSharp.Point(bin_w * (i - 1), hist_h - Math.Round(b_hist.At<float>(i - 1))),
                        new OpenCvSharp.Point(bin_w * (i), hist_h - Math.Round(b_hist.At<float>(i))),
                        new Scalar(255, 0, 0),
                        1,
                        LineTypes.Link8,
                        0);

                Cv2.Line(histImage,
                    new OpenCvSharp.Point(bin_w * (i - 1), hist_h - Math.Round(g_hist.At<float>(i - 1))),
                    new OpenCvSharp.Point(bin_w * (i), hist_h - Math.Round(g_hist.At<float>(i))),
                    new Scalar(0, 255, 0),
                    1,
                    LineTypes.Link8,
                    0);
                Cv2.Line(histImage,
                    new OpenCvSharp.Point(bin_w * (i - 1), hist_h - Math.Round(r_hist.At<float>(i - 1))),
                    new OpenCvSharp.Point(bin_w * (i), hist_h - Math.Round(r_hist.At<float>(i))),
                    new Scalar(0, 0, 255),
                    1,
                    LineTypes.Link8,
                    0);
            }
            return histImage.ToBitmap();
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