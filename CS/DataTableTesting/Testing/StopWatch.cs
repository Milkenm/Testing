using System.Diagnostics;
using System.Windows.Forms;

namespace DataTableTesting.Testing
{
	public class StopWatch
	{
		private Stopwatch s = new Stopwatch();

		public void Start()
		{
			s.Restart();
			s.Start();
		}

		public void Stop()
		{
			s.Stop();
			MessageBox.Show($"Took: {s.ElapsedMilliseconds / 1000} second/s ({s.ElapsedMilliseconds}ms)");
		}
	}
}
