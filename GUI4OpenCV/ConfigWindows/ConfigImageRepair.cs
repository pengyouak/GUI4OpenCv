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
    public partial class ConfigImageRepair : ConfigBaseWindow
    {
        public int R => (int)r.Value;

        public int B => (int)b.Value;

        public int G => (int)g.Value;

        public int V => (int)v.Value;

        public ConfigImageRepair()
        {
            InitializeComponent();
        }
    }
}
