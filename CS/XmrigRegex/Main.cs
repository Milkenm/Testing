﻿using System;
using System.Text;
using System.Windows.Forms;

namespace XmrigRegex
{
	public partial class Main : System.Windows.Forms.Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button_test_Click(object sender, EventArgs e)
		{
			string[] a = label_text.Text.Remove(0, 44).Replace(" H/s", "").Replace(" max", "").Replace("n/a", "0.0").Split(' ');

			StringBuilder sb = new StringBuilder();
			foreach (string cut in a)
			{
				sb.AppendLine("|" + cut + "|");
			}
			MessageBox.Show(sb.ToString());
			/*
			regexLmao2[1] = regexLmao2[1].Replace(" H/s", "");
			
			MessageBox.Show("|" + regexLmao2[0] + "|\n|" + regexLmao2[1] + "|");
			*/
		}
	}
}