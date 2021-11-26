using System;
using System.Text;
using System.Windows.Forms;

namespace TimeZonesTesting
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime eastern = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Eastern Standard Time");
			MessageBox.Show(eastern.Hour.ToString());
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.Text = GetTimeZones();
		}

		public String GetTimeZones()
		{
			StringBuilder sb = null;
			foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
			{
				if (sb == null)
				{
					sb = new StringBuilder(z.Id);
				}
				else
				{
					sb.AppendLine(z.Id);
				}
			}
			return sb.ToString();
		}

		public double GetTimeZoneDifference(String timeZone)
		{
			DateTime eastern = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Eastern Standard Time");
			MessageBox.Show(eastern.Hour.ToString());

			return (DateTime.UtcNow - eastern).;
		}
	}
}
