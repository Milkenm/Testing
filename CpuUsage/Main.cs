using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpuUsage
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();

			Info();
			LoadCPU();
			LoadCPU();
			LoadCPU();
			LoadCPU();
			LoadCPU();
		}

		public async Task Info()
		{
			// https://stackoverflow.com/a/35289332
			await Task.Run(() =>
			{
				PerformanceCounter process_cpu = new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
				while (true)
				{
					Thread.Sleep(500);
					float processUsage = process_cpu.NextValue() / Environment.ProcessorCount;
					listBox1.Items.Add(processUsage);
					listBox1.SelectedIndex = listBox1.Items.Count - 1;
				}
			}).ConfigureAwait(false);
			/*
			await Task.Run(() =>
			{
				// CPU time (or process time) is the amount of time for which a central processing unit (CPU) was used for processing instructions of a computer program or operating system
				PerformanceCounter cpuCounter = new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
				for (int i64 = 0; i64 < 100; ++i64)
				{
					Thread.Sleep(1000);
					listBox1.Items.Add("CPU: " + (cpuCounter.NextValue() / 4) + " %");
				}
			}).ConfigureAwait(false);
			*/
		}

		public async Task LoadCPU()
		{
			await Task.Run(() =>
			{
				int a = 10;

				for (int i = 0; ; i++)
				{
					a += 19028312 * 3 * 12;
				}
			}).ConfigureAwait(false);
		}
	}
}
