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
    public partial class ConfigTranslation : ConfigBaseWindow
    {
        public int MoveX => (int)x.Value;

        public int MoveY => (int)y.Value;

        public ConfigTranslation()
        {
            InitializeComponent();
        }
    }
}
