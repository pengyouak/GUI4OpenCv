using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Collections;

namespace GUI4OpenCV.Helpers
{
    public class MatchOptimizeOptions
    {
        /// <summary>
        /// 3
        /// </summary>
        public bool Binary { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public bool Gray { get; set; } = true;

        /// <summary>
        /// 5
        /// </summary>
        public bool Canny { get; set; }

        /// <summary>
        /// 4
        /// </summary>
        public bool Structure { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        public bool Blur { get; set; }
    }

    public class MatchHelper
    {
        public static MatchOptimizeOptions MatchOptimizeOptions { get; } = new MatchOptimizeOptions();

        private static Hashtable PathCache = new Hashtable();

        /// <summary>
        /// 平方差匹配 CV_TM_SQDIFF：用两者的平方差来匹配，最好的匹配值为0 归一化平方差匹配 CV_TM_SQDIFF_NORMED 相关匹配
        /// CV_TM_CCORR：用两者的乘积匹配，数值越大表明匹配程度越好 归一化相关匹配CV_TM_CCORR_NORMED 相关系数匹配
        /// CV_TM_CCOEFF：用两者的相关系数匹配，1表示完美的匹配，-1表示最差的匹配 归一化相关系数匹配 CV_TM_CCOEFF_NORMED
        /// </summary>
        public static TemplateMatchModes TemplateMatchModes = TemplateMatchModes.CCoeffNormed;

        private static void Cache(string key, bool valid)
        {
            if (!PathCache.ContainsKey(key))
                PathCache.Add(key, valid);
            else
                PathCache[key] = valid;
        }

        private static bool GetCacheValid(string key)
        {
            if (PathCache.ContainsKey(key)) return (bool)PathCache[key];
            else return true;
        }

        public static Mat FindMatFromImage(Bitmap imgSrc, Bitmap imgSub, double threshold = 0.9)
        {
            Mat srcMat = null;
            Mat dstMat = null;
            Mat outArray = null;
            try
            {
                srcMat = imgSrc.ToMat();
                dstMat = imgSub.ToMat();
                outArray = new Mat();

                Cv2.MatchTemplate(srcMat, dstMat, outArray, TemplateMatchModes);
                double minValue, maxValue;
                OpenCvSharp.Point location, point;
                Cv2.MinMaxLoc(outArray, out minValue, out maxValue, out location, out point);
                if (maxValue >= threshold)
                    return outArray.Clone();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (srcMat != null)
                    srcMat.Dispose();
                if (dstMat != null)
                    dstMat.Dispose();
                if (outArray != null)
                    outArray.Dispose();
            }
        }

        public static System.Drawing.Point FindPicFromImage(Bitmap imgSrc, Bitmap imgSub, double threshold = 0.9)
        {
            Mat srcMat = null;
            Mat dstMat = null;
            Mat outArray = null;
            try
            {
                srcMat = imgSrc.ToMat();
                dstMat = imgSub.ToMat();
                outArray = new Mat();

                Cv2.MatchTemplate(srcMat, dstMat, outArray, TemplateMatchModes);
                double minValue, maxValue;
                OpenCvSharp.Point location, point;
                Cv2.MinMaxLoc(outArray, out minValue, out maxValue, out location, out point);

                if (maxValue >= threshold)
                {
                    return new System.Drawing.Point(point.X, point.Y);
                }
                return System.Drawing.Point.Empty;
            }
            catch (FileNotFoundException)
            {
                NLog.LogManager.GetCurrentClassLogger().Error($"失败 文件未找到.");
                return System.Drawing.Point.Empty;
            }
            catch (Exception ex)
            {
                NLog.LogManager.GetCurrentClassLogger().Error($"失败 {ex.Message}.");
                return System.Drawing.Point.Empty;
            }
            finally
            {
                if (srcMat != null)
                    srcMat.Dispose();
                if (dstMat != null)
                    dstMat.Dispose();
                if (outArray != null)
                    outArray.Dispose();
            }
        }

        public static Mat FindMatFromImageByBinary(Bitmap imgSrc, Bitmap imgSub, double threshold = 0.9)
        {
            var src = PretreatmentHelper.RgbToGray(imgSrc);
            //src = OpenCVHelper.GrayToBinary(src);

            var dst = PretreatmentHelper.RgbToGray(imgSub);
            //dst = OpenCVHelper.GrayToBinary(dst);

            return FindMatFromImage(src, dst, threshold);
        }

        public static System.Drawing.Point FindPicFromImage(Bitmap src, string[] subPicPath, double threshold = 0.9)
        {
            Bitmap sub = null;
            foreach (var item in subPicPath)
            {
                if (!System.IO.File.Exists(item))
                {
                    NLog.LogManager.GetCurrentClassLogger().Warn($"子图[{item}]不存在");
                    continue;
                }
                sub = (Bitmap)Bitmap.FromFile(item);
                var point = FindPicFromImage(src, sub, threshold);
                if (point != System.Drawing.Point.Empty)
                {
                    NLog.LogManager.GetCurrentClassLogger().Info($"成功 子图路径[{item}]");
                    return point;
                }
                else
                {
                    NLog.LogManager.GetCurrentClassLogger().Warn($"失败 子图路径[{item}]");
                }
            }
            return System.Drawing.Point.Empty;
        }

        public static System.Drawing.Point FindPicFromImageByOptimization(Bitmap imgSrc, Bitmap imgSub, double threshold = 0.9, MatchOptimizeOptions matchOptimizeOptions = null)
        {
            if (matchOptimizeOptions == null)
            {
                matchOptimizeOptions = MatchOptimizeOptions;
            }

            var src = imgSrc;
            var dst = imgSub;

            if (matchOptimizeOptions.Gray)
            {
                src = PretreatmentHelper.RgbToGray(src);
                dst = PretreatmentHelper.RgbToGray(dst);
            }
            if (matchOptimizeOptions.Blur)
            {
                src = FilterHelper.Blur(src);
                dst = FilterHelper.Blur(dst);
            }
            if (matchOptimizeOptions.Binary)
            {
                src = PretreatmentHelper.GrayToBinary(src);
                dst = PretreatmentHelper.GrayToBinary(dst);
            }
            if (matchOptimizeOptions.Structure)
            {
                src = PretreatmentHelper.Structure(src);
                dst = PretreatmentHelper.Structure(dst);
            }
            if (matchOptimizeOptions.Canny)
            {
                src = FindEdgesHelper.Canny(src);
                dst = FindEdgesHelper.Canny(dst);
            }

            return FindPicFromImage(src, dst, threshold);
        }

        public static System.Drawing.Point FindPicFromImageByOptimization(Bitmap src, string[] subPicPath, double threshold = 0.9, MatchOptimizeOptions matchOptimizeOptions = null)
        {
            Bitmap sub = null;
            foreach (var item in subPicPath)
            {
                if (!System.IO.File.Exists(item))
                {
                    NLog.LogManager.GetCurrentClassLogger().Warn($"子图[{item}]不存在");
                    continue;
                }
                sub = (Bitmap)Bitmap.FromFile(item);
                var point = FindPicFromImageByOptimization(src, sub, threshold, matchOptimizeOptions);
                if (point != System.Drawing.Point.Empty)
                {
                    NLog.LogManager.GetCurrentClassLogger().Info($"优化匹配成功 子图路径[{item}]");
                    return point;
                }
                else
                    NLog.LogManager.GetCurrentClassLogger().Warn($"优化匹配失败 子图路径[{item}]");
            }
            return System.Drawing.Point.Empty;
        }
    }
}