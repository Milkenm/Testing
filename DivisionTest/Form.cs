using System;
using static System.Windows.Forms.ListBox;

namespace DivisionTest
{
	public partial class Form : System.Windows.Forms.Form
	{
		public Form()
		{
			InitializeComponent();
		}

		private void timer_refresh_Tick(object sender, EventArgs e)
		{
			textBox_result.Text = (numeric_firstValue.Value % numeric_secondValue.Value).ToString();
		}
	}
}
