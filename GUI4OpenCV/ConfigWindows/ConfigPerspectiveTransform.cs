using OpenCvSharp;
namespace GUI4OpenCV.ConfigWindows
{
    public partial class ConfigPerspectiveTransform : ConfigBaseWindow
    {
        public Point2f[] SourcePoint => new Point2f[] {
            new Point2f((float)x1.Value,(float)y1.Value),
            new Point2f((float)x2.Value,(float)y2.Value),
            new Point2f((float)x3.Value,(float)y3.Value),
            new Point2f((float)x4.Value,(float)y4.Value),
        };

        public Point2f[] DestinationPoint => new Point2f[] {
            new Point2f((float)dx1.Value,(float)dy1.Value),
            new Point2f((float)dx2.Value,(float)dy2.Value),
            new Point2f((float)dx3.Value,(float)dy3.Value),
            new Point2f((float)dx4.Value,(float)dy4.Value),
        };

        public ConfigPerspectiveTransform()
        {
            InitializeComponent();
        }

        public ConfigPerspectiveTransform(int width, int height) : this()
        {
            x1.Value = 0;
            y1.Value = 0;
            x2.Value = width;
            y2.Value = 0;
            x3.Value = 0;
            y3.Value = height;
            x4.Value = width;
            y4.Value = height;

            dx1.Value = 50;
            dy1.Value = 50;
            dx2.Value = width-50;
            dy2.Value = 50;
            dx3.Value = 0;
            dy3.Value = height;
            dx4.Value = width;
            dy4.Value = height;
        }
    }
}
