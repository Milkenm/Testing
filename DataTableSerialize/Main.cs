using System;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DataTableSerialize
{
	public partial class Main : Form
	{
		private readonly string BinaryFilePath = @"C:\Testing\Test.bin";

		private DataTable dt = new DataTable();

		private enum Column
		{
			ID,
			Name,
			Role,
		}

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			// CREATE COLUMNS
			dt.Columns.Add(nameof(Column.ID), typeof(int));
			dt.Columns.Add(nameof(Column.Name), typeof(string));
			dt.Columns.Add(nameof(Column.Role), typeof(Role));

			// SET PRIMARY KEY
			dt.PrimaryKey = new DataColumn[] { dt.Columns[nameof(Column.ID)] };

			// ADD RECORDS
			dt.Rows.Add(1, "Josefino", new Role("CEO"));
			dt.Rows.Add(2, "Albertina", new Role("Employee"));

			// SET DATAGRID DATA SOURCE
			dataGrid.DataSource = dt;
		}

		private void button_save_Click(object sender, EventArgs e)
		{
			FileStream fs = new FileStream(BinaryFilePath, FileMode.Create);
			BinaryFormatter bf = new BinaryFormatter();

			bf.Serialize(fs, dt);
			fs.Close();

			dataGrid.DataSource = dt;
		}

		private void button_read_Click(object sender, EventArgs e)
		{
			FileStream fs = new FileStream(BinaryFilePath, FileMode.Open);
			BinaryFormatter bf = new BinaryFormatter();

			dt = (DataTable)bf.Deserialize(fs);
			fs.Close();

			dataGrid.DataSource = dt;
		}

		private void button_clear_Click(object sender, EventArgs e)
		{
			dt.Clear();

			dataGrid.DataSource = dt;
		}

		private void button_getRoles_Click(object sender, EventArgs e)
		{
			listBox_roles.Items.Clear();

			foreach (DataRow row in dt.Rows)
			{
				listBox_roles.Items.Add(((Role)row[nameof(Column.Role)]).Name);
			}
		}
	}

	public class Role
	{
		public Role() { }

		public Role(string position)
		{
			Name = position;
		}

		public string Name;
	}
}
