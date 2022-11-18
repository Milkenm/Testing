using System.Data;
using System.Data.SQLite;

namespace DataTableTesting
{
	public class TSQLite
	{
		private readonly string DatabasePath;

		public TSQLite(string databasePath)
		{
			DatabasePath = databasePath;
		}

		public void Insert(int amount)
		{
			using (SQLiteConnection sqliteConnection = new SQLiteConnection($"Data Source={DatabasePath}; Version=3;"))
			{
				sqliteConnection.Open();
				using (SQLiteCommand cmd = sqliteConnection.CreateCommand())
				{
					for (int i = 0; i < amount; i++)
					{
						cmd.CommandText = $"INSERT INTO Testing (ID, Value) VALUES ({i}, 'Value {i}')";
						cmd.ExecuteNonQuery();
					}
				}
				sqliteConnection.Close();
			}
		}

		public string Select(int recordId)
		{
			using (SQLiteConnection sqliteConnection = new SQLiteConnection($"Data Source={DatabasePath}; Version=3;"))
			{
				sqliteConnection.Open();
				using (SQLiteCommand cmd = sqliteConnection.CreateCommand())
				{
					cmd.CommandText = $"SELECT Value FROM Testing WHERE Value='Value {recordId}'";
					SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, sqliteConnection);

					DataTable dt = new DataTable();
					da.Fill(dt);

					sqliteConnection.Close();

					return dt.Rows[0][0].ToString();
				}
			}
		}
	}
}
