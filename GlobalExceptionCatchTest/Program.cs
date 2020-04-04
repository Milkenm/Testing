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
			Application.ThreadException += (s, e) => GlobalException();
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			AppDomain.CurrentDomain.UnhandledException += (s, e) => GlobalException();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form());
		}

		private static void GlobalException()
		{
			MessageBox.Show("Exception");
		}

		internal static async Task lmao()
		{
			var task = Task.Factory.StartNew(() => throw new Exception("okghndjfkn"));
			await task;
		}
	}
}