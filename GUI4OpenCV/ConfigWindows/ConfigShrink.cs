﻿using System;
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
    public partial class ConfigShrink : ConfigBaseWindow
    {
        public double ShrinkRate => (double)shrinkRate.Value;

        public ConfigShrink()
        {
            InitializeComponent();
        }
    }
}
