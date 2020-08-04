using System;
using System.Text;
using System.Windows.Forms;

namespace ThousandsSeparator
{
	public partial class Main : System.Windows.Forms.Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button_format_Click(object sender, EventArgs e)
		{
			textBox_formatedNumber.Text = FormatThousand(Convert.ToDecimal(textBox_number.Text.Replace(".", ",")));
		}

		private string FormatThousand(decimal number)
		{
			string[] num = number.ToString().Split(',');

			StringBuilder sb = new StringBuilder();

			int loop = 3 - (num[0].Length % 3);
			if (loop == 3)
			{
				loop = 0;
			}
			
			foreach (char c in num[0])
			{
				if (c == '.')
				{
					break;
				}
				else if (loop != 0 && loop % 3 == 0)
				{
					sb.Append(',');
				}
				sb.Append(c);

				loop++;
			}
			if (num.Length > 1)
			{
				sb.Append('.').Append(num[1]);
			}

			return sb.ToString();
		}
	}
}
