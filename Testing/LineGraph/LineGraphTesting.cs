#region Usings
using System;
using System.Drawing;
using System.Windows.Forms;
#endregion Usings



namespace Testing.LineGraph
{
	public partial class LineGraphTesting : Form
	{
		int X, Y;

		public LineGraphTesting()
		{
			InitializeComponent();
		}

		private void button_draw_Click(object sender, EventArgs e)
		{
			X += 25;
			Y += 25;
			LineGraph.Line l = new LineGraph.Line(new Pen(Color.Black, 1), X - 25, Y - 25, X, Y, LineGraph.PositionList.BottomLeft);

			lineGraph.DrawLine(l);
		}

		private void button_increment_Click(object sender, EventArgs e)
		{
			lineGraph.IncrementLine(new Pen(Color.Black, 1), X + 10, Y - 10, LineGraph.PositionList.BottomLeft, true);
		}
	}
}
