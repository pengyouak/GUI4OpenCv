using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI4OpenCV.ConfigWindows
{
    public partial class ConfigMorphologyEx : ConfigBaseWindow
    {
        public MorphTypes MorphTypes => (MorphTypes)cboMorphTypes.SelectedItem;

        public ConfigMorphologyEx()
        {
            InitializeComponent();

            cboMorphTypes.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var item in Enum.GetValues(typeof(MorphTypes)))
            {
                cboMorphTypes.Items.Add((MorphTypes)Enum.Parse(typeof(MorphTypes), item.ToString()));
            }
            cboMorphTypes.SelectedIndex = 0;
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (((MorphTypes)cboMorphTypes.SelectedItem) == MorphTypes.HitMiss)
            {
                MessageBox.Show("此类型会执行异常，暂不支持选择，或者可以通过代码自行修正后选择。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            base.btnOK_Click(sender, e);
        }
    }
}
