using DiamondJogoDoGalo.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiamondJogoDoGalo
{
	public partial class Main : Form
	{
		private static Bitmap board = new Bitmap(Resources.Board_PNG);
		private static Bitmap playerX = new Bitmap(Resources.X_PNG);
		private static Bitmap playerO = new Bitmap(Resources.O_PNG);
		private string player = "X";

		public Main()
		{
			InitializeComponent();

			pictureBox_board.Image = board;
		}

		private void ButtonClick(object sender, EventArgs e)
		{
			Button b = (Button)sender;


			switch (b.Name)
			{
				case "button1":
					UpdateBoard(new Point(0, 0)); break;
				case "button2":
					UpdateBoard(new Point(48, 0)); break;
				case "button3":
					UpdateBoard(new Point(96, 0)); break;
				case "button4":
					UpdateBoard(new Point(0, 48)); break;
				case "button5":
					UpdateBoard(new Point(48, 48)); break;
				case "button6":
					UpdateBoard(new Point(96, 48)); break;
				case "button7":
					UpdateBoard(new Point(0, 96)); break;
				case "button8":
					UpdateBoard(new Point(48, 96)); break;
				case "button9":
					UpdateBoard(new Point(96, 96)); break;
			}

			pictureBox_board.Image = board;

			if (player == "X")
			{
				player = "O";
			}
			else
			{
				player = "X";
			}
		}

		public void UpdateBoard(Point position)
		{
			Graphics bGraphics = Graphics.FromImage(board);
			bGraphics.CompositingMode = CompositingMode.SourceOver;

			if (player == "X")
			{
				bGraphics.DrawImage(playerX, position);
			}
			else
			{
				bGraphics.DrawImage(playerO, position);
			}
		}
	}
}
