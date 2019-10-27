#region Usings
using System;
using System.Drawing;
using System.Windows.Forms;
#endregion Usings



namespace Testing
{
	public partial class LineGraphic : Form
	{
		Graphics panelGraphics;


		public LineGraphic()
		{
			InitializeComponent();

			panelGraphics = panel_graphic.CreateGraphics();
		}

		private void button_draw_Click(object sender, EventArgs e)
		{
			int xEnd = (int)(numeric_lineXstart.Value + numeric_lineXend.Value);
			int yEnd = (int)(numeric_lineYstart.Value + numeric_lineYend.Value);
			
			Pen myPen = new Pen(Color.Red);
			myPen.Width = 2;

			panelGraphics.DrawLine(myPen, (int)numeric_lineXstart.Value, panel_graphic.Size.Height - (int)numeric_lineYstart.Value, xEnd, panel_graphic.Size.Height - yEnd);

			numeric_lineXstart.Value = xEnd;
			numeric_lineYstart.Value = yEnd;
		}

		private void button_drawTest_Click(object sender, EventArgs e)
		{
			Pen pen = new Pen(Color.Black);
			pen.Width = 2;

			for (int i = 100; i > 0; i -= 10)
			{
				panelGraphics.DrawLine(pen, 0, i, i, 0);
			}
		}
	}
}
