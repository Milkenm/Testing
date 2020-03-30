using System;
using System.Windows.Forms;

namespace ThousandsSeparator
{
	public partial class Form : System.Windows.Forms.Form
	{
		public Form()
		{
			InitializeComponent();
		}

		private void button_format_Click(object sender, EventArgs e)
		{
			try
			{

				decimal number = Convert.ToDecimal(textBox_number.Text);

				// n0 = 1
				// n1 = 1.0
				// n2 = 1.00
				// ...
				textBox_formatedNumber.Text = string.Format("{0:n3}", number).Replace(",", ".");
			}
			catch
			{
				MessageBox.Show("ex");
			}
		}
	}
}
