using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataTableTest
{
    internal static class Program
    {
        private static void Main()
        {
            DataTable GamesTable = new DataTable();
            GamesTable.Columns.Add("Host", typeof(string));
            GamesTable.Columns.Add("Opponent", typeof(string));
            GamesTable.Columns.Add("MessageId", typeof(int));
            GamesTable.Columns.Add("ChannelId", typeof(ulong));
            GamesTable.Columns.Add("Game", typeof(string));

            GamesTable.Rows.Add("Host 1", "Opponent 1", 1, 1, "Game 1");
            GamesTable.Rows.Add("Host 2", "Opponent 2", 2, 2, "Game 2");
            GamesTable.Rows.Add("Host 3", "Opponent 3", 3, 3, "Game 3");
            GamesTable.Rows.Add("Host 4", "Opponent 4", 4, 4, "Game 4");
            GamesTable.Rows.Add("Host 5", "Opponent 5", 5, 5, "Game 5");

            List<string> hosts = GamesTable.AsEnumerable().Select(r => r.Field<string>("Host")).ToList();

            foreach (string s in hosts)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}