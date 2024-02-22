using System.Reflection;

using EntityFrameworkTest.Models;

using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkTest.Data
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; } = null!;
		public DbSet<Order> Orders { get; set; } = null!;
		public DbSet<Product> Products { get; set; } = null!;
		public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string installationPath = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!;
			string dbPath = Path.Join(@"C:\Users\migcampos\Desktop\GitHub\Testing\CS\EntityFrameworkTest\bin\Debug\net7.0\", @"\Data\DiamondDB.db");
			_ = optionsBuilder.UseSqlite($"Data Source={dbPath}");
		}
	}
}
