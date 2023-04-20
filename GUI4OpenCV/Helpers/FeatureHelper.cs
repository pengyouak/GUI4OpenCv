using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Face;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class FeatureHelper
    {
        public static Bitmap LBP(Bitmap bitmap)
        {
            using var src = bitmap.ToMat();

            // 计算LBP特征
            using Mat lbpImage = new Mat();
            Cv2.Laplacian(src, lbpImage, MatType.CV_8U, 1, 1, 0, BorderTypes.Default);
            Cv2.Threshold(lbpImage, lbpImage, 128, 255, ThresholdTypes.Binary);

            // 显示LBP图像
            return lbpImage.ToBitmap();

            //// 提取LBP特征向量
            // Mat lbpHist = new Mat();
            //Cv2.CalcHist(new Mat[] { lbpImage }, new int[] { 0 }, null, lbpHist, 1, new int[] { 256 }, new Rangef[] { new Rangef(0, 256) });

            //// 归一化特征向量
            //lbpHist = lbpHist / (src.Rows * src.Cols);
        }
    }
}
