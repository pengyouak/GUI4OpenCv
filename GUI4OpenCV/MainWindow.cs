using GUI4OpenCV.ConfigWindows;
using GUI4OpenCV.Helpers;
using System.Drawing.Imaging;
using System.Globalization;
using System.Transactions;

namespace GUI4OpenCV
{
    public partial class MainWindow : Form
    {
        private string _sourceImagePath = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Ë½ÓÐ·½·¨
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
                item.Item1.ContextMenuStrip = contextMenuStrip1;
                table.Controls.Add(item.Item1);
                table.SetRow(item.Item1, item.Item2.X);
                table.SetColumn(item.Item1, item.Item2.Y);
            }
            table.ResumeLayout();
        }

        #endregion

        #region ÓÒ¼ü²Ëµ¥
        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            var diag = new SaveFileDialog()
            {
                AddExtension = true,
                Title = "±£´æÍ¼Ïñ",
                Filter = "Png|*.png",
                DefaultExt = "*.png",
            };
            if (diag.ShowDialog() != DialogResult.OK) return;

            var toolTripMenuItem = sender as ToolStripMenuItem;
            var contextMenuStrip = toolTripMenuItem.GetCurrentParent() as ContextMenuStrip;
            var sourcePicControl = contextMenuStrip.SourceControl as PictureBox;
            var image = sourcePicControl.Image;

            image.Save(diag.FileName, ImageFormat.Png);

            MessageBoxHelper.ShowInformationMessageBox("±£´æ³É¹¦");
        }

        private void mnuBig_Click(object sender, EventArgs e)
        {
            var toolTripMenuItem = sender as ToolStripMenuItem;
            var contextMenuStrip = toolTripMenuItem.GetCurrentParent() as ContextMenuStrip;
            var sourcePicControl = contextMenuStrip.SourceControl as PictureBox;
            var image = sourcePicControl.Image;
            var form = new Form()
            {
                StartPosition = FormStartPosition.CenterScreen,
                WindowState= FormWindowState.Maximized
            };
            var pic = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = image,
            };
            form.Controls.Add(pic);
            form.ShowDialog();
        }
        #endregion

        #region Í¼ÏñÇúÏß

        private void btnGryHist_Click(object sender, EventArgs e)
        {
            ChangeTable(2, 1);
            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            SetControlPosition(new List<(Control, Point)>
            {
                (picBottomLeft,new Point(1,0)),
            });

            picBottomLeft.Image = PretreatmentHelper.GrayHistogram((Bitmap)picTopLeft.Image);
        }

        #endregion

        #region Í¼ÏñÔ¤´¦Àí
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Filter = "Í¼ÏñÎÄ¼þ(*.jpg,*.png,*.jpeg,*.bmp)|*.jpg;*.png;*.jpeg;*.bmp|ËùÓÐÀàÐÍ(*.*)|*.*",
                Title = "Ñ¡ÔñÍ¼Ïñ",
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
            ChangeTable(1, 1);
            picTopLeft.Image = PretreatmentHelper.RgbToGray((Bitmap)Image.FromFile(_sourceImagePath));
        }

        private void btnEqualHist_Click(object sender, EventArgs e)
        {
            ChangeTable(1, 1);
            picTopLeft.Image = PretreatmentHelper.EqualizeHist((Bitmap)Image.FromFile(_sourceImagePath));
        }

        private void btnBanary_Click(object sender, EventArgs e)
        {
            var config = new ConfigGrayToBanary();
            if (config.ShowDialog() != DialogResult.OK) return;
            ChangeTable(1, 1);

            var image = Image.FromFile(_sourceImagePath);
            picTopLeft.Image = PretreatmentHelper.GrayToBinary(PretreatmentHelper.RgbToGray((Bitmap)image), config.Thresh, config.MaxVal);
        }

        private void btnStructure_Click(object sender, EventArgs e)
        {
            var config = new ConfigStructure();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 1);
            var img = Image.FromFile(_sourceImagePath);
            picTopLeft.Image = PretreatmentHelper.Structure((Bitmap)img, config.SWidth, config.SHeight);
        }

        private void btnHSV_Click(object sender, EventArgs e)
        {
            ChangeTable(1, 1);
            var img = Image.FromFile(_sourceImagePath);
            picTopLeft.Image = PretreatmentHelper.HSV((Bitmap)img);
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            ChangeTable(1, 1);
            var img = Image.FromFile(_sourceImagePath);
            picTopLeft.Image = PretreatmentHelper.Revert((Bitmap)img);
        }
        #endregion

        #region ±ßÔµ¼ì²â
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

        #region ÂË²¨

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

        #region Í¼Ïñ±ä»»

        private void btnHoughLineTransfer_Click(object sender, EventArgs e)
        {
            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = ImageTransformHelper.HouphLineTransferStraight(img);
        }

        private void btnHoughLinTransferCurve_Click(object sender, EventArgs e)
        {
            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = ImageTransformHelper.HouphLineTransferCurve(img);
        }

        #endregion

        #region Í¼ÏñÐÞ¸´

        private void btnImgRepair_Click(object sender, EventArgs e)
        {
            var config = new ConfigImageRepair();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = ImageProcessHelper.ImageRepair(img, config.R + config.G + config.B - config.V, config.R + config.G + config.B + config.V);
        }

        private void btnDenoise_Click(object sender, EventArgs e)
        {
            ChangeTable(1, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = ImageProcessHelper.ImageDenoise(img);
        }
        #endregion

        #region Î»ÖÃ±ä»»

        private void btnShrink_Click(object sender, EventArgs e)
        {
            var config = new ConfigResize();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            var img = picTopLeft.Image;
            picTopRight.Image = PositionTransformHelper.Resize((Bitmap)img, config.ShrinkRate);
        }

        private void btnOverturn_Click(object sender, EventArgs e)
        {
            var config = new ConfigOverTurn();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            var img = picTopLeft.Image;
            picTopRight.Image = PositionTransformHelper.OverTurn((Bitmap)img, config.LeftToRight);
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            var img = picTopLeft.Image;
            var config = new ConfigRotate(img.Width, img.Height);
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = PositionTransformHelper.Rotate((Bitmap)img, config.CenterPoint.X, config.CenterPoint.Y, config.Angle, config.Scale);
        }

        private void btnTranslation_Click(object sender, EventArgs e)
        {
            var config = new ConfigTranslation();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            var img = picTopLeft.Image;
            picTopRight.Image = PositionTransformHelper.Translation((Bitmap)img, config.MoveX, config.MoveY);
        }

        private void btnAffine_Click(object sender, EventArgs e)
        {
            var img = picTopLeft.Image;
            var config = new ConfigAffineTransform(img.Width, img.Height);
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = PositionTransformHelper.AffineTransform((Bitmap)img, config.SourcePoint, config.DestinationPoint);
        }

        private void btnPerspective_Click(object sender, EventArgs e)
        {
            var img = picTopLeft.Image;
            var config = new ConfigPerspectiveTransform(img.Width, img.Height);
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = PositionTransformHelper.PerspectiveTransform((Bitmap)img, config.SourcePoint, config.DestinationPoint);
        }
        #endregion

        #region ÔëÉù
        private void btnSaltNoisy_Click(object sender, EventArgs e)
        {
            var config = new ConfigSaltNoisy();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            var img = picTopLeft.Image;
            picTopRight.Image = NoiseHelper.Salt((Bitmap)img, Color.FromArgb(config.R, config.G, config.B), config.NoiseCount);
        }

        private void btnGaussianNoisy_Click(object sender, EventArgs e)
        {
            var config = new ConfigGaussianNoisy();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            var img = picTopLeft.Image;
            picTopRight.Image = NoiseHelper.Gaussian((Bitmap)img, config.Mean, config.StdDev);
        }

        private void btnPoissonNoisy_Click(object sender, EventArgs e)
        {
            var config = new ConfigPoissonNoisy();
            if (config.ShowDialog() != DialogResult.OK) return;

            ChangeTable(1, 2);
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            var img = picTopLeft.Image;
            picTopRight.Image = NoiseHelper.Poisson((Bitmap)img, config.Lambda);
        }
        #endregion
    }
}