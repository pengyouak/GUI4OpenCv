using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class VideoHelper
    {
        /// <summary>
        /// 帧间差分 
        /// 首先打开视频文件并读取第一帧。然后将第一帧转换为灰度图像，并在循环中处理每一帧。
        /// 对于每一帧，我们将其转换为灰度图像，计算帧间差分，应用阈值，并显示结果。
        /// 最后，更新上一帧并释放资源。
        /// </summary>
        /// <param name="videoPath"></param>
        public static void FrameDiff(string videoPath)
        {
            // 打开视频文件
            VideoCapture capture = new VideoCapture(videoPath);

            // 检查视频是否打开
            if (!capture.IsOpened())
            {
                Console.WriteLine("无法打开视频文件！");
                return;
            }

            // 读取第一帧
            Mat frame1 = new Mat();
            capture.Read(frame1);

            // 转换为灰度图像
            Cv2.CvtColor(frame1, frame1, ColorConversionCodes.BGR2GRAY);

            // 循环处理视频帧
            while (true)
            {
                // 读取下一帧
                Mat frame2 = new Mat();
                capture.Read(frame2);

                // 检查是否读取到了最后一帧
                if (frame2.Empty())
                {
                    break;
                }

                // 转换为灰度图像
                Cv2.CvtColor(frame2, frame2, ColorConversionCodes.BGR2GRAY);

                // 计算帧间差分
                Mat diff = new Mat();
                Cv2.Absdiff(frame1, frame2, diff);

                // 应用阈值
                Mat threshold = new Mat();
                Cv2.Threshold(diff, threshold, 30, 255, ThresholdTypes.Binary);

                // 显示结果
                Cv2.ImShow("Frame Difference", threshold);
                Cv2.WaitKey(1);

                // 更新上一帧
                frame1 = frame2.Clone();
            }

            // 释放资源
            capture.Release();
            Cv2.DestroyAllWindows();
        }

        /// <summary>
        /// 高斯混合
        /// 首先打开视频文件并创建一个BackgroundSubtractorMOG2对象来执行高斯混合。
        /// 然后，在循环中处理每一帧，并应用高斯混合来计算前景掩码。
        /// 最后，显示结果并释放资源。
        /// </summary>
        /// <param name="videoPath"></param>
        public static void GaussianMix(string videoPath)
        {
            // 打开视频文件
            VideoCapture capture = new VideoCapture("video.mp4");

            // 检查视频是否打开
            if (!capture.IsOpened())
            {
                Console.WriteLine("无法打开视频文件！");
                return;
            }

            // 创建高斯混合模型
            BackgroundSubtractorMOG2 mog = BackgroundSubtractorMOG2.Create();

            // 循环处理视频帧
            while (true)
            {
                // 读取下一帧
                Mat frame = new Mat();
                capture.Read(frame);

                // 检查是否读取到了最后一帧
                if (frame.Empty())
                {
                    break;
                }

                // 应用高斯混合
                Mat mask = new Mat();
                mog.Apply(frame, mask);

                // 显示结果
                Cv2.ImShow("Gaussian Mixture", mask);
                Cv2.WaitKey(1);
            }

            // 释放资源
            capture.Release();
            Cv2.DestroyAllWindows();
        }
    }
}