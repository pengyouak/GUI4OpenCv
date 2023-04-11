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
    public partial class ConfigGrayToBanary : ConfigBaseWindow
    {
        public double Thresh => (double)thresh.Value;

        public double MaxVal => (double)maxval.Value;

        public ConfigGrayToBanary()
        {
            InitializeComponent();
        }
    }
}
