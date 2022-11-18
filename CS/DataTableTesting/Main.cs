using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Windows.Forms;

namespace DataTableTesting
{
	public partial class Main : Form
	{
		private static DataTable DTable = new DataTable();
		private static int ID = 0;

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			DTable.Columns.Add("ID", typeof(int));
			DTable.Columns.Add("Value", typeof(string));

			dataGrid.DataSource = DTable;
		}

		private void AddRecords(int amount)
		{
			Stopwatch s = new Stopwatch();
			s.Start();

			for (int i = 0; i < amount; i++)
			{
				DTable.Rows.Add(ID, "Value " + ID);
				ID++;
			}

			s.Stop();
			MessageBox.Show("Took: " + s.ElapsedMilliseconds / 1000 + " second/s");
		}

		private void button_addRecords_Click(object sender, EventArgs e)
		{
			AddRecords((int)num_amount.Value);

			//dataGrid.FirstDisplayedScrollingRowIndex = dataGrid.Rows.Count - 1;
		}

		private void SaveDataTable(object sender, EventArgs e)
		{
			FileStream fs = new FileStream(@"C:\test.bin", FileMode.Create);
			BinaryFormatter bf = new BinaryFormatter();
			bf.Serialize(fs, DTable);
			fs.Close();

			MessageBox.Show("Saved!");
		}

		//Deserialize DataTable from File
		private void ReadDataTable(object sender, EventArgs e)
		{
			DTable.Clear();
			FileStream fs = new FileStream(@"C:\test.bin", FileMode.Open);
			BinaryFormatter bf = new BinaryFormatter();
			DTable = (DataTable)bf.Deserialize(fs);
			fs.Close();

			dataGrid.DataSource = DTable;

			MessageBox.Show("Loaded");
		}

		private void button_select_Click(object sender, EventArgs e)
		{
			Stopwatch s = new Stopwatch();
			s.Start();
			DataRow selection = DTable.Select("Value='Value 555555'")[0];
			s.Stop();
			MessageBox.Show(selection["ID"].ToString());
			MessageBox.Show("Took: " + s.ElapsedMilliseconds / 1000 + " second/s");
		}
	}
}
