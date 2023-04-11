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
    public partial class ConfigBoxFilter : ConfigBaseWindow
    {
        public int KSize => (int)ksize.Value;

        public ConfigBoxFilter()
        {
            InitializeComponent();
        }
    }
}
