using DataTableTesting.Testing;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTableTesting
{
	public partial class Main2 : Form
	{
		TSQLite tsqlite = new TSQLite(@"C:\Users\migcampos\Desktop\TestDataBase.db");
		TDataTable tdt = new TDataTable();
		StopWatch s = new StopWatch();

		private static readonly int amount = 1000;
		private static readonly int recordId = amount / 2;

		public Main2()
		{
			InitializeComponent();
		}

		private void button_sqliteInsert_Click(object sender, EventArgs e)
		{
			s.Start();
			tsqlite.Insert(amount);
			s.Stop();
		}

		private void button_sqliteSelect_Click(object sender, EventArgs e)
		{
			s.Start();
			string result = tsqlite.Select(recordId);
			s.Stop();
			MessageBox.Show(result);
		}

		private void button_datatableInsert_Click(object sender, EventArgs e)
		{
			s.Start();
			tdt.Insert(amount);
			s.Stop();
		}

		private void button_datatableSelect_Click(object sender, EventArgs e)
		{
			s.Start();
			string result = tdt.Select(recordId);
			s.Stop();
			MessageBox.Show(result);
		}
	}
}
