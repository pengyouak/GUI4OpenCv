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
    public partial class ConfigGaussianNoisy : ConfigBaseWindow
    {
        public double Mean => (double)mean.Value;

        public double StdDev => (double)stdDev.Value;

        public ConfigGaussianNoisy()
        {
            InitializeComponent();
        }
    }
}
