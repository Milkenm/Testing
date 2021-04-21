using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GetIconFromProcess
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button_getIcon_Click(object sender, EventArgs e)
		{
			Process[] pList = Process.GetProcessesByName(textBox_processName.Text);

			if (pList.Length > 0)
			{
				Process p = pList[0];
				Icon icon = Icon.ExtractAssociatedIcon(p.MainModule.FileName);
				Image img = icon.ToBitmap();

				pictureBox_icon.Image = img;

				NotifyIcon ni = new NotifyIcon();
				ni.Icon = icon;
				ni.Visible = true;
				// Menu: Open | Exit
				ni.Click += new EventHandler((_s, _e) => { ni.Visible = false; });
			}
			else
			{
				MessageBox.Show("No processes found.");
			}
		}
	}
}
