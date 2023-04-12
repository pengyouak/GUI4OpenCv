using GUI4OpenCV.Extensions;

namespace GUI4OpenCV
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.SetUnhandledExceptionMode( UnhandledExceptionMode.CatchException, true );
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;

            Application.Run(new MainWindow());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            NLog.LogManager.GetCurrentClassLogger().Error(e.Exception);
            if (e.Exception != null)
            {
                e.Exception?.InnerException.Message.ShowErrorMessageBox(e.Exception.InnerException.Message);
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            NLog.LogManager.GetCurrentClassLogger().Error(e.ExceptionObject as Exception);
            if (e.ExceptionObject as Exception != null)
            {
                (e.ExceptionObject as Exception).Message.ShowErrorMessageBox((e.ExceptionObject as Exception).InnerException.Message);
            }
        }
    }
}