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
    public partial class ConfigBlur : ConfigBaseWindow
    {
        public int BlurWidth => (int)nwidth.Value;

        public int BlurHeight => (int)nheight.Value;

        public ConfigBlur()
        {
            InitializeComponent();
        }
    }
}
