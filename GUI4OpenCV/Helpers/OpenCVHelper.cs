﻿using NumSharp;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.IO;

namespace GUI4OpenCV.Helpers
{
    public class OpenCVHelper
    {
        #region 边缘检测
        /// <summary>
        /// 边缘检测Canny
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Bitmap Canny(Bitmap bitmap, double threshold1=100, double threshold2=255, int apertureSize=3, bool L2gradient=false)
        {
            using var dst = new Mat();
            Cv2.Canny(bitmap.ToMat(), dst, threshold1, threshold2, apertureSize, L2gradient);
            var t = dst.ToBitmap();
            return t;
        }

        #region Roberts
        /// <summary>
        /// 边缘检测Roberts算子X向量
        /// </summary>
        /// <returns></returns>
        public static Bitmap RobertsX(Bitmap bitmap)
        {
            using Mat dst = new Mat();
            Cv2.CvtColor(bitmap.ToMat(), dst, ColorConversionCodes.BGR2GRAY);

            using (Mat src = dst)
            using (Mat dstX = new Mat())
            {
                #region Robert算子
                //Robert算子 X向量
                ///*
                // *   +1       0
                // *   
                // *    0      -1
                // *   
                // *   二位矩阵
                // */
                InputArray kernelRX = InputArray.Create<int>(new int[2, 2] { { 1, 0 }, { 0, -1 } });
                Cv2.Filter2D(src, dstX, src.Depth(), kernelRX, new OpenCvSharp.Point(-1, -1), 0);
                #endregion

                return dstX.ToBitmap();
            }
        }

        /// <summary>
        /// 边缘检测Roberts算子Y向量
        /// </summary>
        /// <returns></returns>
        public static Bitmap RobertsY(Bitmap bitmap)
        {
            using Mat dst = new Mat();
            Cv2.CvtColor(bitmap.ToMat(), dst, ColorConversionCodes.BGR2GRAY);

            using (Mat src = dst)
            using (Mat dstY = new Mat())
            {
                #region Robert算子
                //Robert算子 Y向量
                ///*
                //*     0      +1
                //*     
                //*    -1       0
                //*   
                //*   二位矩阵
                //*/
                InputArray kernelRY = InputArray.Create<int>(new int[2, 2] { { 0, 1 }, { -1, 0 } });
                Cv2.Filter2D(src, dstY, src.Depth(), kernelRY, new OpenCvSharp.Point(-1, -1), 0);
                #endregion

                return dstY.ToBitmap();
            }
        }

        /// <summary>
        /// 边缘检测Roberts算子
        /// </summary>
        /// <returns></returns>
        public static Bitmap Roberts(Bitmap bitmap)
        {
            var robertsX = RobertsX(bitmap);
            var robertsY = RobertsY(bitmap);
           
            using Mat x = new Mat();
            using Mat y = new Mat();
            Cv2.ConvertScaleAbs(robertsX.ToMat(), x);
            Cv2.ConvertScaleAbs(robertsY.ToMat(), y);

            using Mat roberts = new Mat();  
            Cv2.AddWeighted(x, 0.5, y, 0.5, 0, roberts);

            return roberts.ToBitmap();
        }
        #endregion

        #region Sobel算子

        public static Bitmap SobelX(Bitmap bitmap)
        {
            using Mat srcGry = new Mat();
            Cv2.CvtColor(bitmap.ToMat(), srcGry, ColorConversionCodes.BGR2GRAY);
            //Sobel算子 X向量
            ///*
            // *   -1   0    1
            // *   -2   0    2
            // *   -1   0    1
            // *   
            // *   二位矩阵
            // */
            InputArray kernelRX = InputArray.Create<int>(new int[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } });
            using Mat dstX = new Mat();
            //Cv2.Filter2D(src, dstX, src.Depth(), kernelRX, new Point(-1, -1), 0);
            Cv2.Filter2D(srcGry, dstX, -1, kernelRX, new OpenCvSharp.Point(-1, -1), 0, 0);

            return dstX.ToBitmap();
        }

        public static Bitmap SobelY(Bitmap bitmap)
        {
            using Mat srcGry = new Mat();
            Cv2.CvtColor(bitmap.ToMat(), srcGry, ColorConversionCodes.BGR2GRAY);
            //Sobel算子 Y向量
            ///*
            //*     -1    -2    -1
            //*      0     0     0
            //*      1     2     1
            //*   
            //*   二位矩阵
            //*/
            InputArray kernelRY = InputArray.Create<int>(new int[3, 3] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 2 } });
            using Mat dstY = new Mat();
            //Cv2.Filter2D(src, dstY, src.Depth(), kernelRY, new Point(-1, -1), 0);
            Cv2.Filter2D(srcGry, dstY, -1, kernelRY, new OpenCvSharp.Point(-1, -1), 0, 0);

            return dstY.ToBitmap();
        }

        /// <summary>
        /// 边缘检测Sobel算子
        /// </summary>
        /// <param name="path"></param>
        public static Bitmap Sobel(Bitmap bitmap)
        {
            var sobelX = SobelX(bitmap);
            var sobelY = SobelY(bitmap);

            using Mat x = new Mat();
            using Mat y = new Mat();
            Cv2.ConvertScaleAbs(sobelX.ToMat(), x);
            Cv2.ConvertScaleAbs(sobelY.ToMat(), y);

            using Mat sobel = new Mat();
            Cv2.AddWeighted(x, 0.5, y, 0.5, 0, sobel);

            return sobel.ToBitmap();
        }
        #endregion

        #endregion
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