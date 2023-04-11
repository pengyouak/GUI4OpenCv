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
                Filter = "图像文件(*.jpg,*.png,*.jpeg,*.bmp)|*.jpg;*.png;*.jpeg;*.bmp|所有类型(*.*)|*.*",
                Title = "选择图像",
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

            picTopRight.Image = OpenCVHelper.Canny(img, config.Threshold1, config.Threshold2, config.ApertureSize, config.L2gradient);
            picBottomLeft.Image = OpenCVHelper.Canny(img, config.Threshold1 / 2, config.Threshold2 / 2, config.ApertureSize, config.L2gradient);
            picBottomRight.Image = OpenCVHelper.Canny(img, config.Threshold1 / 3, config.Threshold2 / 3, config.ApertureSize, config.L2gradient);
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
            picTopRight.Image = OpenCVHelper.Roberts(img);
            picBottomLeft.Image = OpenCVHelper.RobertsX(img);
            picBottomRight.Image = OpenCVHelper.RobertsY(img);
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
            picTopRight.Image = OpenCVHelper.Sobel(img);
            picBottomLeft.Image = OpenCVHelper.SobelX(img);
            picBottomRight.Image = OpenCVHelper.SobelY(img);
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
            picTopRight.Image = OpenCVHelper.Laplace(img);
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
            picTopRight.Image = OpenCVHelper.Prewitt(img);
            picBottomLeft.Image = OpenCVHelper.PrewittX(img);
            picBottomRight.Image = OpenCVHelper.PrewittY(img);
        }

        private void btnKrisch_Click(object sender, EventArgs e)
        {
            ChangeTable(2, 3);
            var picTopMid = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picTopRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomLeft = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomMid = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };
            var picBottomRight = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage };

            SetControlPosition(new List<(Control, Point)>
            {
                (picTopMid,new Point(0,1)),
                (picTopRight,new Point(0,2)),
                (picBottomLeft,new Point(1,0)),
                (picBottomMid,new Point(1,1)),
                (picBottomRight,new Point(1,2)),
            });

            var img = (Bitmap)picTopLeft.Image;
            picTopMid.Image = OpenCVHelper.Krisch(img);
            picTopRight.Image = OpenCVHelper.KrischNorth(img);
            picBottomLeft.Image = OpenCVHelper.KrischNorthWest(img);
            picBottomMid.Image = OpenCVHelper.KrischWest(img);
            picBottomRight.Image = OpenCVHelper.KrischSouthWest(img);
        }
    }
}