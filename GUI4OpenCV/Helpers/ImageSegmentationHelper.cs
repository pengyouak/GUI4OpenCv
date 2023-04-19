using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class ImageSegmentationHelper
    {
        private const int GC_BGD = 0;
        private const int GC_FGD = 1;
        private const int GC_PR_BGD = 2;
        private const int GC_PR_FGD = 3;

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

        public static Bitmap Watershed(Bitmap bitmap, int x, int y, Color fileColor, double value=30)
        {
            using Mat src = bitmap.ToMat();

            using Mat marker = new Mat(src.Rows, src.Cols, MatType.CV_32SC1);
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    marker.Set<int>(194 + j, 191 + i, 3);
                }
            }

            Cv2.Watershed(src, marker);

            using Mat result = new Mat(marker.Rows, marker.Cols, MatType.CV_8UC3);
            for (int i = 0; i < marker.Width; i++)
            {
                for (int j = 0; j < marker.Height; j++)
                {
                    byte v = marker.Get<byte>(j, i);
                    result.Set<Vec3b>(j, i, new Vec3b(0, 0, 255));
                    break;
                }
            }
            return result.ToBitmap();
        }

        /// <summary>
        /// 分水岭算法（png图像不适合）
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="alpha"></param>
        /// <param name="beta"></param>
        /// <param name="thresh"></param>
        /// <param name="maxval"></param>
        /// <returns></returns>
        public static Bitmap Watershed(Bitmap bitmap, double alpha=0, double beta=255, double thresh=1, double maxval=255)
        {
            using Mat src = bitmap.ToMat();

            // 转换为灰度图像
            Mat gray = new Mat();
            Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);

            // 对图像进行二值化处理
            using Mat binary = new Mat();
            Cv2.Threshold(gray, binary, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);
            
            //对二值化图像进行距离变换
            using Mat distance = new Mat() ;
            Cv2.DistanceTransform(binary, distance, DistanceTypes.L2,DistanceTransformMasks.Mask5);
        
            //对距离变换结果进行归一化处理
            using Mat distanceNorm = new Mat();
            Cv2.Normalize(distance, distanceNorm, 0, 255, NormTypes.MinMax);
    
            //对归一化后的结果进行调值处理，得到种子点
            Mat seeds = new Mat();
            Cv2.Threshold(distanceNorm, seeds, 1, 255, ThresholdTypes.Binary);
       
            // 对种子点进行膨胀操作
            using Mat kernel = Cv2.GetStructuringElement(MorphShapes.Ellipse, new OpenCvSharp.Size(10, 10));
            using Mat seedsDil = new Mat();
            Cv2.Dilate(seeds, seedsDil, kernel);

            using var dist8U=new Mat();
            distanceNorm.ConvertTo(dist8U, MatType.CV_8U);

            // 对距离变换结果进行标记
            Mat markers = new Mat();
            Cv2.ConnectedComponents(dist8U, markers);

            // 对标记进行加一操作
            markers = markers + 1;
            // 将未知区域标记为0
            Cv2.BitwiseNot(binary, binary); // 将 binary 取反
            markers.SetTo(0, binary);
            //markers.SetTo(0, binary == 255);

            // 进行分水岭算法
            Cv2.Watershed(src, markers);

            // 对分水岭算法的结果进行可视化处理
            using Mat result = new Mat();
            src.CopyTo(result);
            for (int i = 0; i < markers.Rows; i++)
            {
                for (int j = 0; j < markers.Cols; j++)
                {
                    if(markers.At<int>(i,j)== -1)
                    {
                        result.Set(i,j,new Vec3b(255,0,0)); // 将分水岭线标记为红色
                    }
                }
            }

            return result.ToBitmap();
        }

        public static Bitmap Grabcuts(Bitmap bitmap, int areaX, int areaY, int areaWidth,int areaHeight, int itercount = 5)
        {
            using var src = bitmap.ToMat();

            // 创建掩码和标签矩阵
            using var mask = new Mat(src.Size(), MatType.CV_8UC1, Scalar.Black);
            using var bgdModel= new Mat();
            using var fgdModel= new Mat();
            var rect = new Rect(areaX, areaY, areaWidth, areaHeight); // 设置矩形区域

            // 进行 GrabCut 算法
            Cv2.GrabCut(src, mask, rect, bgdModel, fgdModel, itercount, GrabCutModes.InitWithRect);

            using var result = new Mat();
            Cv2.Compare(mask, new Scalar((double)GrabCutClasses.PR_FGD), result, CmpType.EQ);

            return result.ToBitmap();
        }

        public static Bitmap MeanShift(Bitmap bitmap, double sp=5, double sr=50)
        {
            using var src = bitmap.ToMat();

            using Mat result = new Mat();
            Cv2.PyrMeanShiftFiltering(src, result, 5, 50);

            return result.ToBitmap();
        }
    }
}
