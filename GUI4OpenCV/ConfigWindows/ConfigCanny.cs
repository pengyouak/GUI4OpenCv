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
    public partial class ConfigCanny : ConfigBaseWindow
    {
        public double Threshold1 => (double)threshold1.Value;

        public double Threshold2 => (double)threshold2.Value;

        public int ApertureSize => (int)apertureSize.Value;

        public bool L2gradient => l2gradient.Checked;

        public ConfigCanny()
        {
            InitializeComponent();
        }
    }
}
