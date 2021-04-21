using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DetectWindowMinimize
{
	class Program
	{
		static void Main(string[] args)
		{
			Process[] processes = Process.GetProcessesByName("githubdesktop");
			if (processes.Length > 0)
			{
				Process p = processes[0];
				IntPtr wHnd = p.MainWindowHandle;
				Console.WriteLine("Minimized: " + IsIconic(wHnd));
			}
			else
			{
				Console.WriteLine("No processes found.");
			}

			Console.ReadLine();
		}

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool IsIconic(IntPtr hWnd);
	}
}
