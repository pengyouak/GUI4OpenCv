namespace GUI4OpenCV
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Filter = "图像文件(*.jpg,*.png,*.jpeg,*.bmp)|*.jgp;*.png;*.jpeg;*.bmp|所有类型(*.*)|*.*",
                Title = "选择图像",
                FilterIndex = 0,
                Multiselect = false,
                CheckFileExists = true,
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            var image = Image.FromFile(dlg.FileName);

            picTopLeft.Image = image;
            picTopRight.Image = image;
            picBottomLeft.Image = image;
            picBottomRight.Image = image;
        }
    }
}