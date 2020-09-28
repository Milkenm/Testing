using System.Data;

namespace DataTableTesting
{
	public class TDataTable
	{
		public DataTable DTable = new DataTable();

		public TDataTable()
		{
			DTable.Columns.Add("ID", typeof(int));
			DTable.Columns.Add("Value", typeof(string));
		}

		public void Insert(int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				DTable.Rows.Add(i, $"Value {i}");
			}
		}

		public string Select(int recordId)
		{
			return DTable.Select($"Value='Value {recordId}'")[0][0].ToString();
		}
	}
}
