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
            var image = Image.FromFile(dlg.FileName);

            ChangeTable(1, 1);
            picTopLeft.Image = image;
        }

        #region ±ßÔµ¼ì²â
        private void btnCanny_Click(object sender, EventArgs e)
        {
            var config = new ConfigCanny();
            if (config.ShowDialog() != DialogResult.OK) return;


            ChangeTable(2, 2);
            var img = (Bitmap)picTopLeft.Image;

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

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
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

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
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

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
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

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
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

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
            var picTopMid = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picTopMidRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

            var picMidLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picMidMid = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picMidMidRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picMidRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomMid = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

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

            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopRight,new Point(0,1)),
            });

            picTopRight.Image = OpenCVHelper.Blur(img, config.BlurWidth, config.BlurHeight);
        }

        #endregion
    }
}