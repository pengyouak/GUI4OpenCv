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
    public partial class ConfigStructure : ConfigBaseWindow
    {
        public int SWidth => (int)width.Value;

        public int SHeight => (int)height.Value;

        public ConfigStructure()
        {
            InitializeComponent();
        }
    }
}
