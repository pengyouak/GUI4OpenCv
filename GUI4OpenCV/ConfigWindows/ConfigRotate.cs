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
    public partial class ConfigRotate : ConfigBaseWindow
    {
        public Point CenterPoint => new Point((int)x.Value, (int)y.Value);

        public double Angle => (double)angle.Value;

        public double Scale => (double)scale.Value;

        public ConfigRotate()
        {
            InitializeComponent();
        }

        public ConfigRotate(int width, int height) : this()
        {
            if (width < 2048)
                x.Value = width / 2;

            if (height < 2048)
                y.Value = height / 2;
        }
    }
}
