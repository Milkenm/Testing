using System;
using System.Data;
using System.Windows.Forms;

namespace DataTableRowInsertAtTesting
{
	public partial class Main : Form
	{
		private DataTable DTable = new DataTable();

		public enum Column
		{
			ID,
			Value,
		}

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			DTable.Columns.Add(nameof(Column.ID), typeof(int));
			DTable.Columns.Add(nameof(Column.Value), typeof(string));

			for (int i = 0; i < 10; i++)
			{
				DTable.Rows.Add(i, $"Value {i}");
			}

			dataGrid.DataSource = DTable;
		}

		private void button_insertAt_Click(object sender, EventArgs e)
		{
			int index = (int)numeric_index.Value;

			DTable.Rows.RemoveAt(index);

			DataRow row = DTable.NewRow();
			row[nameof(Column.ID)] = 10;
			row[nameof(Column.Value)] = "Updated Row";

			DTable.Rows.InsertAt(row, index);
		}
	}
}
