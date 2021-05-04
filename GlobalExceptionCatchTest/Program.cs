using System;
using System.Windows.Forms;

namespace GlobalExceptionCatchTest
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			Application.ThreadException += (s, e) => GlobalException(e.Exception.Message);
			AppDomain.CurrentDomain.UnhandledException += (s, e) => GlobalException(e.ExceptionObject.ToString());

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}

		private static void GlobalException(string exception)
		{
			MessageBox.Show("Exception: " + exception);
		}
	}
}