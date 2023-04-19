using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class BackgroundProcessHelper
    {
        public static Bitmap ThreshSegmentation(Bitmap bitmap, double thresh=128, double maxval=255)
        {
            using var src = bitmap.ToMat();
            using var dst = new Mat();

            Cv2.Threshold(src, dst, thresh, maxval, ThresholdTypes.Binary);
            return dst.ToBitmap();
        }

        public static Bitmap OSTUThreshSegmentation(Bitmap bitmap, double thresh = 0, double maxval = 255)
        {
            using var src = PretreatmentHelper.RgbToGray(bitmap).ToMat();
            using var dst = new Mat();

            Cv2.Threshold(src, dst, thresh, maxval, ThresholdTypes.Otsu | ThresholdTypes.Binary);
            return dst.ToBitmap();
        }
    }
}
