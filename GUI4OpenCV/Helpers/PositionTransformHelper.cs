using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace GUI4OpenCV.Helpers
{
    internal class PositionTransformHelper
    {
        /// <summary>
        /// 缩放
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Bitmap Resize(Bitmap bitmap, double p)
        {
            if (p <= 0) return bitmap;

            using var dst = new Mat();
            Cv2.Resize(bitmap.ToMat(), dst, new OpenCvSharp.Size(bitmap.Width * p, bitmap.Height * p), interpolation: InterpolationFlags.Cubic);
            var t = dst.ToBitmap();
            return t;
        }

        /// <summary>
        /// 翻转
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap OverTurn(Bitmap bitmap, bool leftTurnToRight = true)
        {
            using Mat src = bitmap.ToMat();

            using Mat map_x = new Mat(src.Size(), MatType.CV_32FC1);
            using Mat map_y = new Mat(src.Size(), MatType.CV_32FC1);
            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {
                    if (leftTurnToRight)
                    {
                        map_x.Set(j, i, (float)(src.Width - i));
                        map_y.Set(j, i, (float)j);
                    }
                    else
                    {
                        map_x.Set(j, i, (float)i);
                        map_y.Set(j, i, (float)(src.Height - j));
                    }
                }
            }

            using Mat result = new Mat();
            Cv2.Remap(src, result, map_x, map_y);
            return result.ToBitmap();
        }

        /// <summary>
        /// 旋转
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="centerX"></param>
        /// <param name="centerY"></param>
        /// <param name="angle"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static Bitmap Rotate(Bitmap bitmap, float centerX, float centerY, double angle = 30, double scale = 1)
        {
            using Mat src = bitmap.ToMat();
            using Mat M = Cv2.GetRotationMatrix2D(new Point2f(centerX, centerY), angle, scale);
            using Mat result = new Mat();
            Cv2.WarpAffine(src, result, M, src.Size());
            return result.ToBitmap();
        }

        /// <summary>
        /// 平移
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Bitmap Translation(Bitmap bitmap, double x, double y)
        {
            using Mat src = bitmap.ToMat();

            using Mat map_x = new Mat(src.Size(), MatType.CV_32FC1);
            using Mat map_y = new Mat(src.Size(), MatType.CV_32FC1);
            for (int i = (x < 0 ? (int)x * -1 : 0); i < (x < 0 ? src.Width : src.Width - x); i++)
            {
                for (int j = (y < 0 ? (int)y * -1 : 0); j < (y < 0 ? src.Height : src.Height - y); j++)
                {
                    if (i + x < 0) map_x.Set(j, i, 0);
                    else map_x.Set(j, i, (float)(i + x));

                    if (j + y < 0) map_y.Set(j, i, 0);
                    else map_y.Set(j, i, (float)(j + y));
                }
            }

            using Mat result = new Mat();
            Cv2.Remap(src, result, map_x, map_y);
            return result.ToBitmap();
        }

        /// <summary>
        /// 放射变换
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="srcPositions">原图三个参照点的坐标</param>
        /// <param name="dstPositions">最终位置的三个点坐标</param>
        /// <returns></returns>
        public static Bitmap AffineTransform(Bitmap bitmap, Point2f[] srcPositions, Point2f[] dstPositions)
        {
            if (srcPositions == null || dstPositions == null) throw new ArgumentNullException();
            if (dstPositions.Length != 3 || srcPositions.Length != 3) throw new InvalidOperationException();

            using Mat src = bitmap.ToMat();
            using Mat M = Cv2.GetAffineTransform(srcPositions, dstPositions);
            using Mat result = new Mat();
            Cv2.WarpAffine(src, result, M, new OpenCvSharp.Size(src.Width + 50, src.Height));
            return result.ToBitmap();
        }

        /// <summary>
        /// 透视变换
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="srcPositions">原图四边形的顶点坐标</param>
        /// <param name="dstPositions">目标图的四边形顶点组坐标</param>
        /// <returns></returns>
        public static Bitmap PerspectiveTransform(Bitmap bitmap, Point2f[] srcPositions, Point2f[] dstPositions)
        {
            if (srcPositions == null || dstPositions == null) throw new ArgumentNullException();
            if (dstPositions.Length != 4 || srcPositions.Length != 4) throw new InvalidOperationException();

            using Mat src = bitmap.ToMat();
            Mat M = Cv2.GetPerspectiveTransform(srcPositions, dstPositions);
            using Mat result = new Mat();
            Cv2.WarpPerspective(src, result, M, new OpenCvSharp.Size(src.Width, src.Height));
            return result.ToBitmap();
        }
    }
}
