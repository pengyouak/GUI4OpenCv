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
    public partial class ConfigWatershed : ConfigBaseWindow
    {
        public int Alpha => (int)alpha.Value;

        public int Beta => (int)beta.Value;

        public int Thresh => (int)beta.Value;

        public int MaxVal => (int)beta.Value;

        public ConfigWatershed()
        {
            InitializeComponent();
        }
    }
}
