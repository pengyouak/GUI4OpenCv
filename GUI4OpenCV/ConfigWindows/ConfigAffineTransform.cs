using OpenCvSharp;
namespace GUI4OpenCV.ConfigWindows
{
    public partial class ConfigAffineTransform : ConfigBaseWindow
    {
        public Point2f[] SourcePoint => new Point2f[] { 
            new Point2f((float)x1.Value,(float)y1.Value), 
            new Point2f((float)x2.Value,(float)y2.Value), 
            new Point2f((float)x3.Value,(float)y3.Value),
        };

        public Point2f[] DestinationPoint => new Point2f[] {
            new Point2f((float)dx1.Value,(float)dy1.Value),
            new Point2f((float)dx2.Value,(float)dy2.Value),
            new Point2f((float)dx3.Value,(float)dy3.Value),
        };

        public ConfigAffineTransform()
        {
            InitializeComponent();
        }

        public ConfigAffineTransform(int width, int height):this()
        {
            x1.Value = 0;
            y1.Value = 0;
            x2.Value = 0;
            y2.Value = height;
            x3.Value = width;
            y3.Value = height;

            dx1.Value = 50;
            dy1.Value = 50;
            dx2.Value = 0;
            dy2.Value = height;
            dx3.Value = width;
            dy3.Value = height;
        }
    }
}
