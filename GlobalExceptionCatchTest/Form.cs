using System;

namespace GlobalExceptionCatchTest
{
	public partial class Form : System.Windows.Forms.Form
	{
		public Form()
		{
			InitializeComponent();
		}

		private void button_exception_Click(object sender, EventArgs e)
		{
			throw new Exception("Throw Exception");
		}
	}
}
