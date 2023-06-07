using EntityFrameworkTest.Data;
using EntityFrameworkTest.Models;

internal class Program
{
	private static void Main(string[] args)
	{
		using DatabaseContext context = new DatabaseContext();

		Product p1 = new Product()
		{
			Name = "Veggie",
			Price = 9.99M
		};
		context.Products.Add(p1);

		Product p2 = new Product()
		{
			Name = "Deluxe",
			Price = 12.99M,
		};
		context.Add(p2);

		context.SaveChanges();
	}
}