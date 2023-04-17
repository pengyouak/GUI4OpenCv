using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class ImageProcessHelper
    {
        public static Bitmap ImageRepair(Bitmap bitmap, int rgbTotalStart, int rgbTotalEnd)
        {
            using Mat src = bitmap.ToMat();
            //找出损坏区域
            using Mat mask = new Mat(src.Size(), MatType.CV_8UC1, new Scalar(0));
            for (int i = 0; i < src.Width; i++)
            {
                for (int j = 0; j < src.Height; j++)
                {
                    Vec3b color = src.Get<Vec3b>(j, i);
                    int rgbTotal = color[0] + color[1] + color[2];
                    if (rgbTotal >= rgbTotalStart  && rgbTotal <= rgbTotalEnd)
                    {
                        mask.Set<byte>(j, i, 1);
                        mask.Set<byte>(j + 1, i, 1);
                        mask.Set<byte>(j, i + 1, 1);
                        mask.Set<byte>(j - 1, i, 1);
                        mask.Set<byte>(j, i - 1, 1);
                        mask.Set<byte>(j + 1, i + 1, 1);
                        mask.Set<byte>(j - 1, i - 1, 1);
                        mask.Set<byte>(j + 1, i - 1, 1);
                        mask.Set<byte>(j - 1, i + 1, 1);
                    }
                }
            }

            using Mat result = new Mat();
            Cv2.Inpaint(src, mask, result, 5, InpaintMethod.Telea);
            
            return result.ToBitmap();
        }
    }
}
