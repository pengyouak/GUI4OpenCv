using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace GUI4OpenCV.Helpers
{
    internal class ImageTransferHelper
    {
        public static Bitmap HouphLineTransferStraight(Bitmap bitmap)
        {
            using Mat srcLine = bitmap.ToMat();
            using (Mat dst = new Mat(srcLine.Size(), MatType.CV_8UC3, Scalar.Blue))
            {
                // 1:边缘检测
                Mat canyy = new Mat(srcLine.Size(), srcLine.Type());
                Cv2.Canny(srcLine, canyy, 60, 200, 3, false);

                /*
                 *  HoughLinesP:使用概率霍夫变换查找二进制图像中的线段。
                 *  参数：
                 *      1； image: 输入图像 （只能输入单通道图像）
                 *      2； rho:   累加器的距离分辨率(以像素为单位) 生成极坐标时候的像素扫描步长
                 *      3； theta: 累加器的角度分辨率(以弧度为单位)生成极坐标时候的角度步长，一般取值CV_PI/180 ==1度
                 *      4； threshold: 累加器阈值参数。只有那些足够的行才会返回 投票(>阈值)；设置认为几个像素连载一起                     才能被看做是直线。
                 *      5； minLineLength: 最小线长度，设置最小线段是有几个像素组成。
                 *      6；maxLineGap: 同一条线上的点之间连接它们的最大允许间隙。(默认情况下是0）：设置你认为像素之间                     间隔多少个间隙也能认为是直线
                 *      返回结果:
                 *      输出线。每条线由一个4元向量(x1, y1, x2，y2)
                 */
                LineSegmentPoint[] linePiont = Cv2.HoughLinesP(canyy, 1, 1, 1, 1, 10);//只能输入单通道图像
                Scalar color = new Scalar(0, 255, 255);
                for (int i = 0; i < linePiont.Count(); i++)
                {
                    OpenCvSharp.Point p1 = linePiont[i].P1;
                    OpenCvSharp.Point p2 = linePiont[i].P2;
                    Cv2.Line(dst, p1, p2, color, 4, LineTypes.Link8);
                }

                return dst.ToBitmap();
            }
        }

        public static Bitmap HouphLineTransferCurve(Bitmap bitmap)
        {
            using Mat src = bitmap.ToMat();
            using (Mat dst = new Mat())
            {

                //1:因为霍夫圆检测对噪声比较敏感，所以首先对图像做一个中值滤波或高斯滤波(噪声如果没有可以不做)
                Mat m1 = new Mat();
                Cv2.MedianBlur(src, m1, 3); //  ksize必须大于1且是奇数

                //2：转为灰度图像
                Mat m2 = new Mat();
                Cv2.CvtColor(m1, m2, ColorConversionCodes.BGR2GRAY);

                //3：霍夫圆检测：使用霍夫变换查找灰度图像中的圆。
                /*
                 * 参数：
                 *      1：输入参数： 8位、单通道、灰度输入图像
                 *      2：实现方法：目前，唯一的实现方法是HoughCirclesMethod.Gradient
                 *      3: dp      :累加器分辨率与图像分辨率的反比。默认=1
                 *      4：minDist: 检测到的圆的中心之间的最小距离。(最短距离-可以分辨是两个圆的，否则认为是同心圆-                            src_gray.rows/8)
                 *      5:param1:   第一个方法特定的参数。[默认值是100] canny边缘检测阈值低
                 *      6:param2:   第二个方法特定于参数。[默认值是100] 中心点累加器阈值 – 候选圆心
                 *      7:minRadius: 最小半径
                 *      8:maxRadius: 最大半径
                 * 
                 */
                CircleSegment[] cs = Cv2.HoughCircles(m2, HoughModes.Gradient, 1, 80, 70, 30, 10, 60);
                src.CopyTo(dst);
                // Vec3d vec = new Vec3d();
                for (int i = 0; i < cs.Count(); i++)
                {
                    //画圆
                    Cv2.Circle(dst, (int)cs[i].Center.X, (int)cs[i].Center.Y, (int)cs[i].Radius, new Scalar(0, 0, 255), 2, LineTypes.AntiAlias);
                    //加强圆心显示
                    Cv2.Circle(dst, (int)cs[i].Center.X, (int)cs[i].Center.Y, 3, new Scalar(0, 0, 255), 2, LineTypes.AntiAlias);
                }
                return dst.ToBitmap();
            }
        }
    }
}
