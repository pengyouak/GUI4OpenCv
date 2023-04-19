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
    public partial class ConfigMeanShift : ConfigBaseWindow
    {
        public int SP => (int)sp.Value;

        public int SR => (int)sr.Value;

        public ConfigMeanShift()
        {
            InitializeComponent();
        }
    }
}
