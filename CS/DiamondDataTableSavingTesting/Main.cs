using System;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DiamondDataTableSavingTesting
{
	public partial class Main : Form
	{
		private readonly string BinaryFilePath = @"C:\Testing\Kek.bin";
		private DataTable dt = new DataTable();

		public Main()
		{
			InitializeComponent();
		}

		private void button_load_Click(object sender, EventArgs e)
		{
			FileStream fs = new FileStream(BinaryFilePath, FileMode.Open);
			BinaryFormatter bf = new BinaryFormatter();

			dt = (DataTable)bf.Deserialize(fs);
			fs.Close();

			dataGrid_dataTable.DataSource = dt;
		}
	}
}
