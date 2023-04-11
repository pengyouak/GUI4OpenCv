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
    public partial class ConfigGaussianBlur : ConfigBaseWindow
    {
        public int KSize => (int)ksize.Value;

        public double SigmaX => (double)sigmaX.Value;

        public ConfigGaussianBlur()
        {
            InitializeComponent();
        }
    }
}
