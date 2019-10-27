#region Usings
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
#endregion Usings



namespace Testing.LineGraph
{
	public partial class LineGraphConcept : Form
	{
		Graphics panelGraphics;





		public LineGraphConcept()
		{
			InitializeComponent();

			panelGraphics = panel_graphic.CreateGraphics();
		}

		private void button_draw_Click(object sender, EventArgs e)
		{
			AddPoint((int)numeric_lineXend.Value, (int)numeric_lineYend.Value);
		}

		private void button_drawTest_Click(object sender, EventArgs e)
		{
			int maxVal = panel_graphic.Height;
			int increment = 10;

			for (int i = maxVal; i > 0; i -= increment)
			{
				Pen pen = new Pen(Color.Black, 1);

				Line bl = new Line(pen, 0, i, maxVal + increment - i, 0, PositionList.BottomLeft);
				Line br = new Line(pen, 0, i, maxVal + increment - i, 0, PositionList.BottomRight);
				Line tl = new Line(pen, 0, i, maxVal + increment - i, 0, PositionList.TopLeft);
				Line tr = new Line(pen, 0, i, maxVal + increment - i, 0, PositionList.TopRight);

				DrawLine(bl);
				DrawLine(br);
				DrawLine(tl);
				DrawLine(tr);
			}
		}

		void AddPoint(int X, int Y)
		{
			int xEnd = (int)numeric_lineXstart.Value + X;
			int yEnd = (int)numeric_lineYstart.Value + Y;

			Pen pen = new Pen(Color.Red, 1);
			Line line = new Line(pen, (int)numeric_lineXstart.Value, (int)numeric_lineYstart.Value, X, Y, PositionList.BottomLeft);

			DrawLine(line);

			numeric_lineXstart.Value = X;
			numeric_lineYstart.Value = Y;
		}


















		List<Line> Lines = new List<Line>();

		struct Line
		{
			public Pen P;
			public int StartX, StartY, EndX, EndY;
			public PositionList Position;

			public Line(Pen _P, int _StartX, int _StartY, int _EndX, int _EndY, PositionList _Pos)
			{
				P = _P;
				StartX = _StartX;
				StartY = _StartY;
				EndX = _EndX;
				EndY = _EndY;
				Position = _Pos;
			}
		}

		enum PositionList
		{
			BottomLeft,
			BottomRight,
			TopLeft,
			TopRight,
		}


		void DrawLine(Line line) => DrawLine(line.P, line.StartX, line.StartY, line.EndX, line.EndY, line.Position, true);
		void DrawLine(Line line, bool SaveLine) => DrawLine(line.P, line.StartX, line.StartY, line.EndX, line.EndY, line.Position, SaveLine);

		void DrawLine(Pen pen, int StartX, int StartY, int EndX, int EndY, PositionList Pos, bool SaveLine)
		{
			switch (Pos)
			{
				case PositionList.BottomLeft:
					{
						panelGraphics.DrawLine(pen, StartX, panel_graphic.Size.Height - StartY, EndX, panel_graphic.Size.Height - EndY);
						break;
					}
				case PositionList.BottomRight:
					{
						panelGraphics.DrawLine(pen, panel_graphic.Size.Width - StartX, panel_graphic.Size.Height - StartY, panel_graphic.Size.Width - EndX, panel_graphic.Size.Height - EndY);
						break;
					}
				case PositionList.TopLeft:
					{
						panelGraphics.DrawLine(pen, StartX, StartY, EndX, EndY);
						break;
					}
				case PositionList.TopRight:
					{
						panelGraphics.DrawLine(pen, panel_graphic.Size.Width - StartX, StartY, panel_graphic.Size.Width - EndX, EndY);
						break;
					}
			}

			if (SaveLine) Lines.Add(new Line(pen, StartX, StartY, EndX, EndY, Pos));
		}

		private void panel_graphic_Paint(object sender, PaintEventArgs e)
		{
			panelGraphics.Clear(Color.White);

			foreach (Line l in Lines)
			{
				DrawLine(l, false);
			}
		}
	}
}
