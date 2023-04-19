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
    public partial class ConfigKittlerThreshSeg : ConfigBaseWindow
    {
        public int Thresh => (int)thresh.Value;

        public int MaxVal => (int)maxval.Value;

        public ConfigKittlerThreshSeg()
        {
            InitializeComponent();
        }
    }
}
