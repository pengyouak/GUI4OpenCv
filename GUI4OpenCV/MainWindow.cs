using GUI4OpenCV.ConfigWindows;
using GUI4OpenCV.Helpers;
using System.Globalization;

namespace GUI4OpenCV
{
    public partial class MainWindow : Form
    {
        private string _sourceImagePath = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeTable(int rows, int columns)
        {
            table.Controls.Clear();
            table.RowStyles.Clear();
            table.ColumnStyles.Clear();
            table.RowCount = rows;
            table.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            }

            for (int i = 0; i < columns; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            }

            table.Controls.Add(picTopLeft);
            table.SetRow(picTopLeft, 0);
            table.SetColumn(picTopLeft, 0);
        }

        private void SetControlPosition(List<(Control, Point)> values)
        {
            table.SuspendLayout();
            foreach (var item in values)
            {
                table.Controls.Add(item.Item1);
                table.SetRow(item.Item1, item.Item2.X);
                table.SetColumn(item.Item1, item.Item2.Y);
            }
            table.ResumeLayout();
        }

        #region ͼ��Ԥ����
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Filter = "ͼ���ļ�(*.jpg,*.png,*.jpeg,*.bmp)|*.jpg;*.png;*.jpeg;*.bmp|��������(*.*)|*.*",
                Title = "ѡ��ͼ��",
                FilterIndex = 0,
                Multiselect = false,
                CheckFileExists = true,
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            _sourceImagePath = dlg.FileName;

            ChangeTable(1, 1);
            var image = Image.FromFile(_sourceImagePath);
            picTopLeft.Image = image;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_sourceImagePath))
            {
                var image = Image.FromFile(_sourceImagePath);
                picTopLeft.Image = image;
            }
        }

        private void btnGry_Click(object sender, EventArgs e)
        {
            picTopLeft.Image = PretreatmentHelper.RgbToGray((Bitmap)picTopLeft.Image);
        }

        private void btnGryHist_Click(object sender, EventArgs e)
        {
            ChangeTable(2, 1);
            var picBottom = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picBottom,new Point(1,0)),
            });

            var img = (Bitmap)picTopLeft.Image;
            picBottom.Image = PretreatmentHelper.GrayHistogram(img);
        }

        private void btnEqualHist_Click(object sender, EventArgs e)
        {
            picTopLeft.Image = PretreatmentHelper.EqualizeHist((Bitmap)picTopLeft.Image);
        }

        private void btnBanary_Click(object sender, EventArgs e)
        {
            var config = new ConfigGrayToBanary();
            if (config.ShowDialog() != DialogResult.OK) return;

            var image = Image.FromFile(_sourceImagePath);
            picTopLeft.Image = PretreatmentHelper.GrayToBinary(PretreatmentHelper.RgbToGray((Bitmap)image), config.Thresh, config.MaxVal);
        }

        private void btnShrink_Click(object sender, EventArgs e)
        {
            var config = new ConfigShrink();
            if (config.ShowDialog() != DialogResult.OK) return;

            var img = (Bitmap)picTopLeft.Image;
            picTopLeft.Image = PretreatmentHelper.Shrink(img, config.ShrinkRate);
        }

        private void btnStructure_Click(object sender, EventArgs e)
        {
            var config = new ConfigStructure();
            if (config.ShowDialog() != DialogResult.OK) return;

            var img = (Bitmap)picTopLeft.Image;
            picTopLeft.Image = PretreatmentHelper.Structure(img, config.SWidth, config.SHeight);
        }
        #endregion

        #region ��Ե���
        private void btnCanny_Click(object sender, EventArgs e)
        {
            var config = new ConfigCanny();
            if (config.ShowDialog() != DialogResult.OK) return;


            ChangeTable(2, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picBottomRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
                (picBottomLeft,new Point(1,0)),
                (picBottomRight,new Point(1,1)),
            });

            picTopRight.Image = FindEdgesHelper.Canny(img, config.Threshold1, config.Threshold2, config.ApertureSize, config.L2gradient);
            picBottomLeft.Image = FindEdgesHelper.Canny(img, config.Threshold1 / 2, config.Threshold2 / 2, config.ApertureSize, config.L2gradient);
            picBottomRight.Image = FindEdgesHelper.Canny(img, config.Threshold1 / 3, config.Threshold2 / 3, config.ApertureSize, config.L2gradient);
        }

        private void btnRoberts_Click(object sender, EventArgs e)
        {
            ChangeTable(2, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picBottomRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
                (picBottomLeft,new Point(1,0)),
                (picBottomRight,new Point(1,1)),
            });

            var img = (Bitmap)picTopLeft.Image;
            picTopRight.Image = FindEdgesHelper.Roberts(img);
            picBottomLeft.Image = FindEdgesHelper.RobertsX(img);
            picBottomRight.Image = FindEdgesHelper.RobertsY(img);
        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            ChangeTable(2, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picBottomRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
                (picBottomLeft,new Point(1,0)),
                (picBottomRight,new Point(1,1)),
            });

            var img = (Bitmap)picTopLeft.Image;
            picTopRight.Image = FindEdgesHelper.Sobel(img);
            picBottomLeft.Image = FindEdgesHelper.SobelX(img);
            picBottomRight.Image = FindEdgesHelper.SobelY(img);
        }

        private void btnLaplace_Click(object sender, EventArgs e)
        {
            ChangeTable(1, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            var img = (Bitmap)picTopLeft.Image;
            picTopRight.Image = FindEdgesHelper.Laplace(img);
        }

        private void btnPrewitt_Click(object sender, EventArgs e)
        {
            ChangeTable(2, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picBottomRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
                (picBottomLeft,new Point(1,0)),
                (picBottomRight,new Point(1,1)),
            });

            var img = (Bitmap)picTopLeft.Image;
            picTopRight.Image = FindEdgesHelper.Prewitt(img);
            picBottomLeft.Image = FindEdgesHelper.PrewittX(img);
            picBottomRight.Image = FindEdgesHelper.PrewittY(img);
        }

        private void btnKrisch_Click(object sender, EventArgs e)
        {
            var config = new ConfigKrisch();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(3, 4);
            var picTopMid = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picTopMidRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            var picMidLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picMidMid = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picMidMidRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picMidRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            var picBottomMid = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopMid,new Point(0,1)),
                (picTopMidRight,new Point(0,2)),
                (picTopRight,new Point(0,3)),

                (picMidLeft,new Point(1,0)),
                (picMidMid,new Point(1,1)),
                (picMidMidRight,new Point(1,2)),
                (picMidRight,new Point(1,3)),

                (picBottomLeft,new Point(2,0)),
                (picBottomMid,new Point(2,1)),
            });

            var img = (Bitmap)picTopLeft.Image;
            picTopMid.Image = FindEdgesHelper.Krisch(img, config.Alpha, config.Beta, config.Delta);
            picTopMidRight.Image = FindEdgesHelper.KrischNorth(img, config.Delta);
            picTopRight.Image = FindEdgesHelper.KrischNorthEast(img, config.Delta);

            picMidLeft.Image = FindEdgesHelper.KrischEast(img, config.Delta);
            picMidMid.Image = FindEdgesHelper.KrischSouthEast(img, config.Delta);
            picMidMidRight.Image = FindEdgesHelper.KrischSouth(img, config.Delta);
            picMidRight.Image = FindEdgesHelper.KrischSouthWest(img, config.Delta);

            picBottomLeft.Image = FindEdgesHelper.KrischWest(img, config.Delta);
            picBottomMid.Image = FindEdgesHelper.KrischNorthWest(img, config.Delta);
        }
        #endregion

        #region �˲�

        private void btnBlur_Click(object sender, EventArgs e)
        {
            var config = new ConfigBlur();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = FilterHelper.Blur(img, config.BlurWidth, config.BlurHeight);
        }

        private void btnMedianBlur_Click(object sender, EventArgs e)
        {
            var config = new ConfigMedianBlur();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = FilterHelper.MedianBlur(img, config.KSize);
        }

        private void btnBilateralFilter_Click(object sender, EventArgs e)
        {
            var config = new ConfigBilateralFilter();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = FilterHelper.BilateralFilter(img, config.D, config.SigmaColor, config.SigmaSpace);
        }

        private void btnOpaque_Click(object sender, EventArgs e)
        {
            var config = new ConfigOpaque();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = FilterHelper.Opaque(img, config.KSize);
        }

        private void btnGaussianBlur_Click(object sender, EventArgs e)
        {
            var config = new ConfigGaussianBlur();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = FilterHelper.GaussianBlur(img, config.KSize, config.SigmaX);
        }

        private void btnBoxFilter_Click(object sender, EventArgs e)
        {
            var config = new ConfigBoxFilter();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = FilterHelper.BoxFilter(img, config.KSize);
        }

        private void btnMorphologyEx_Click(object sender, EventArgs e)
        {
            var config = new ConfigMorphologyEx();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = FilterHelper.MorphologyEx(img, config.MorphTypes);
        }

        #endregion
    }
}