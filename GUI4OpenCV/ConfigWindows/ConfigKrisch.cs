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
    public partial class ConfigKrisch : ConfigBaseWindow
    {
        public double Delta => (double)delta.Value;

        public double Alpha => (double)alpha.Value;

        public double Beta => (double)beta.Value;


        public ConfigKrisch()
        {
            InitializeComponent();
        }
    }
}
