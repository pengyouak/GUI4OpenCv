using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI4OpenCV.Helpers
{
    internal class MessageBoxHelper
    {
        public static DialogResult ShowInformationMessageBox(string text, string title = "提示")
        {
            return MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowWarningMessageBox(string text, string title = "警告")
        {
            return MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowErrorMessageBox(string text, string title = "错误")
        {
            return MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowQuestionMessageBox(string text, string title = "提示")
        {
            return MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
