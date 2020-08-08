using System;
using System.Data;

namespace DynamicDataTable
{
    internal static class Program
    {
        private static void Main()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(object));

            dt.PrimaryKey = new DataColumn[] { dt.Columns["Value"] };

            dt.Rows.Add(1);
            dt.Rows.Add("Text");

            if (dt.Rows.Contains("Text"))
            {
                Console.WriteLine("Contains");
            }
            else
            {
                Console.WriteLine("Does not contain");
            }
        }
    }
}
