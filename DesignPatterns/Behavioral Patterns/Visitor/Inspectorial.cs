using DesignPatterns.Behavioral_Patterns.Visitor.Interfaces;
using DesignPatterns.Behavioral_Patterns.Visitor.Products;
using DesignPatterns.Behavioral_Patterns.Visitor.Visitors;

namespace DesignPatterns.Behavioral_Patterns.Visitor;

public class Inspectorial
{
	public void CalculateTaxes()
	{
		CalculateProductsPerishable();
		Console.WriteLine(new String('-', 40));
		CalculateProductsNotPerishable();
	}

	private static void CalculateProductsNotPerishable()
	{
		List<ProductNotPerishable> productNotPerishables = new()
		{
			new ProductNotPerishable("Antena wifi", 500),
			new ProductNotPerishable("Perfume", 1000)
		};

		Console.WriteLine("\nCalculando imposto produtos nao pereciveis:\n");

		foreach (var product in productNotPerishables)
		{
			Console.WriteLine($"Produto: {product.Name}\nPeso: {product.Weight}");

			foreach (var visitor in GetVisitors())
				visitor.CalculteTaxProductNotPerishable(product);
		}
	}

	private static void CalculateProductsPerishable()
	{
		List<ProductPerishable> productPerishables = new()
		{
			new ProductPerishable("Especiarias", 200),
			new ProductPerishable("Polpa de frutas", 3000)
		};

		Console.WriteLine("\nCalculando imposto produtos nao pereciveis:\n");

		foreach (var product in productPerishables)
		{
			Console.WriteLine($"Produto: {product.Name}\nPeso: {product.Weight}");

			foreach (var visitor in GetVisitors())
				visitor.CalculteTaxProductPerishable(product);
		}
	}

	private static List<IVisitor> GetVisitors() => new()
	{
		new SaoPauloVisitor(), new RioDeJaneiroVisitor()
	};
}