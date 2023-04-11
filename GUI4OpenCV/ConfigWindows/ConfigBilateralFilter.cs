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
    public partial class ConfigBilateralFilter : ConfigBaseWindow
    {
        public int D => (int)d.Value;

        public double SigmaColor => (double)sigmaColor.Value;

        public double SigmaSpace => (double)sigmaSpace.Value;

        public ConfigBilateralFilter()
        {
            InitializeComponent();
        }
    }
}
