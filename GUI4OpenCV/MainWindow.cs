using GUI4OpenCV.ConfigWindows;
using GUI4OpenCV.Helpers;

namespace GUI4OpenCV
{
    public partial class MainWindow : Form
    {
        private string _sourceImagePath = "";

        public MainWindow()
        {
            InitializeComponent();
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

            picTopLeft.Image = image;
            picTopRight.Image = image;
            picBottomLeft.Image = image;
            picBottomRight.Image = image;
        }

        private void btnCanny_Click(object sender, EventArgs e)
        {
            var config = new ConfigCanny();
            if (config.ShowDialog() != DialogResult.OK) return;

            var img = (Bitmap)picTopLeft.Image;
            picTopRight.Image = OpenCVHelper.Canny(img, config.Threshold1, config.Threshold2, config.ApertureSize, config.L2gradient);
            picBottomLeft.Image = OpenCVHelper.Canny(img, config.Threshold1 / 2, config.Threshold2 / 2, config.ApertureSize, config.L2gradient);
            picBottomRight.Image = OpenCVHelper.Canny(img, config.Threshold1 / 3, config.Threshold2 / 3, config.ApertureSize, config.L2gradient);
        }

        private void btnRoberts_Click(object sender, EventArgs e)
        {
            var img = (Bitmap)picTopLeft.Image;
            picTopRight.Image = OpenCVHelper.RobertsX(img);
            picBottomLeft.Image = OpenCVHelper.RobertsY(img);
            picBottomRight.Image = OpenCVHelper.Roberts(img);
        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            var img = (Bitmap)picTopLeft.Image;
            picTopRight.Image = OpenCVHelper.SobelX(img);
            picBottomLeft.Image = OpenCVHelper.SobelY(img);
            picBottomRight.Image = OpenCVHelper.Sobel(img);
        }
    }
}