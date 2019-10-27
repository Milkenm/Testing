#region Usings
using System;
using System.Drawing;
using System.Windows.Forms;
#endregion Usings



namespace Testing.LineGraph
{
	public partial class LineGraphTesting : Form
	{
		public LineGraphTesting()
		{
			InitializeComponent();
		}

		private void button_draw_Click(object sender, EventArgs e)
		{
			LineGraph.Line l = new LineGraph.Line(new Pen(Color.Black, 1), 0, 0, 25, 25, LineGraph.PositionList.BottomLeft);

			lineGraph.DrawLine(l);
		}
	}
}
