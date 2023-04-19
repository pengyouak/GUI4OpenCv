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
    public partial class ConfigGrabcuts : ConfigBaseWindow
    {
        public int IterCount => (int)itercount.Value;

        public int X => (int)x.Value;

        public int Y => (int)y.Value;

        public int X1 => (int)width .Value;

        public int Y1 => (int)height.Value;

        public ConfigGrabcuts()
        {
            InitializeComponent();
        }

        public ConfigGrabcuts(Size size):this()
        {
            width.Value = size.Width - 1;
            height.Value = size.Height - 1;
        }
    }
}
