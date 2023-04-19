using OpenCvSharp.Extensions;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class ChartHelper
    {

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
    }
}
