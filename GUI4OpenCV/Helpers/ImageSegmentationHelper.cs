using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class ImageSegmentationHelper
    {
        /// <summary>
        /// 泛洪填充
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="fileColor">填充颜色</param>
        /// <param name="value">阈值</param>
        /// <returns></returns>
        public static Bitmap FloodFill(Bitmap bitmap, int x, int y, Color fileColor, double value=30)
        {
            using Mat src = bitmap.ToMat();
            Cv2.FloodFill(src, 
                new OpenCvSharp.Point(x, y),
                new Scalar(fileColor.B, fileColor.G, fileColor.R), 
                out OpenCvSharp.Rect rect,
                new Scalar(value, value, value),
                new Scalar(value, value, value));
            return src.ToBitmap();
        }
    }
}
