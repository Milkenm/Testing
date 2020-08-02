using System;
using System.Threading.Tasks;
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
			Application.ThreadException += (s, e) => GlobalException();
			AppDomain.CurrentDomain.UnhandledException += (s, e) => GlobalException();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form());
		}

		private static void GlobalException()
		{
			MessageBox.Show("Exception");
		}
	}
}