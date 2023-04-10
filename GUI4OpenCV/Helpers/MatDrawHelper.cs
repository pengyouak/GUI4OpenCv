using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace GUI4OpenCV.Helpers
{
    public class MatDrawHelper
    {
        public static Bitmap DrawRects(Bitmap src, Bitmap sub, double threshold = 0.75)
        {
            var maskMulti = src.ToMat();//复制整个矩阵
            var temp = sub.ToMat();
            var m = MatchHelper.FindMatFromImageByBinary(src, sub, threshold);
            if (m == null) return null;
            for (int i = 1; i < m.Rows; i++)//行遍历
            {
                for (int j = 1; j < m.Cols; j++)//列遍历
                {
                    if (m.At<float>(i, j) >= 0.6)
                        Console.WriteLine("({0}, {1}): {2}", i, j, m.At<float>(i, j));
                    if (m.At<float>(i, j) >= threshold)
                    {
                        Cv2.Rectangle(maskMulti, new OpenCvSharp.Point(j, i), new OpenCvSharp.Point(j + temp.Cols, i + temp.Rows), new Scalar(125), 1);
                    }
                }
            }
            return maskMulti.ToBitmap();
        }

        public static Bitmap DrawRect(Bitmap src, Bitmap sub, double threshold = 0.85)
        {
            var p = MatchHelper.FindPicFromImageByOptimization(src, sub, threshold);
            if (p == System.Drawing.Point.Empty) return null;
            var mat = src.ToMat();
            Cv2.Rectangle(mat, new Rect(p.X, p.Y, sub.Width, sub.Height), new Scalar(125), thickness: 1, lineType: LineTypes.AntiAlias, shift: 0);
            return mat.ToBitmap();
        }
    }
}