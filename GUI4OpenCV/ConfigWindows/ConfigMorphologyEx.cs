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
    }
}
