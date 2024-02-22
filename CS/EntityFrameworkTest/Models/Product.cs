using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkTest.Models
{
	public class Product
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		[Column(TypeName = "decimal(6, 2)")] public decimal Price { get; set; }
	}
}
