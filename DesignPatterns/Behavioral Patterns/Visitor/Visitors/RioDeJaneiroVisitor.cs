using DesignPatterns.Behavioral_Patterns.Visitor.Interfaces;
using DesignPatterns.Behavioral_Patterns.Visitor.Products;

namespace DesignPatterns.Behavioral_Patterns.Visitor.Visitors;

public class RioDeJaneiroVisitor : IVisitor
{
	public double CalculteTaxProductNotPerishable(ProductNotPerishable productNotPerishable)
	{
		var imposto = (productNotPerishable.Weight / 100) / 9;

		Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");

		return imposto;
	}

	public double CalculteTaxProductPerishable(ProductPerishable productPerishable)
	{
		var imposto = (productPerishable.Weight / 100) / 15;

		Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");

		return imposto;
	}
}