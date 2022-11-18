using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormResizeTesting
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			PreventResize(null, null);
		}

		private static bool preventResize;

		private void PreventResize(object sender, EventArgs e)
		{
			if (preventResize)
			{
				preventResize = false;
				MinimumSize = Size;
				MaximumSize = Size;
			}
			else
			{
				preventResize = true;
				MinimumSize = new Size(0, 0);
				MaximumSize = new Size(0, 0);
			}
		}
	}
}
