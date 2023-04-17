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
    }
}
