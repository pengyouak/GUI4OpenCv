using GUI4OpenCV.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Extensions
{
    internal static class MessageBoxExtensions
    {
        public static DialogResult ShowInformationMessageBox(this string message, string title = "提示") => MessageBoxHelper.ShowInformationMessageBox(message, title);

        public static DialogResult ShowWarningMessageBox(this string message, string title = "警告") => MessageBoxHelper.ShowWarningMessageBox(message, title);

        public static DialogResult ShowErrorMessageBox(this string message, string title = "错误") => MessageBoxHelper.ShowErrorMessageBox(message, title);

        public static DialogResult ShowQuestionMessageBox(this string message, string title = "提示") => MessageBoxHelper.ShowQuestionMessageBox(message, title);
    }
}
