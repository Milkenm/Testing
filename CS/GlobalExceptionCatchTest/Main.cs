using System;

namespace GlobalExceptionCatchTest
{
	public partial class Main : System.Windows.Forms.Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button_exception_Click(object sender, EventArgs e)
		{
			throw new Exception("Throw Exception");
		}
	}
}
