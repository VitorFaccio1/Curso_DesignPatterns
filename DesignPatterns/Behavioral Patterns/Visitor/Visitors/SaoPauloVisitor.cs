using DesignPatterns.Behavioral_Patterns.Visitor.Interfaces;
using DesignPatterns.Behavioral_Patterns.Visitor.Products;

namespace DesignPatterns.Behavioral_Patterns.Visitor.Visitors;

public class SaoPauloVisitor : IVisitor
{
	public double CalculteTaxProductNotPerishable(ProductNotPerishable productNotPerishable)
	{
		var imposto = (productNotPerishable.Weight / 100) / 7;

		Console.WriteLine($"Imposto São Paulo: {imposto}");

		return imposto;
	}

	public double CalculteTaxProductPerishable(ProductPerishable productPerishable)
	{
		var imposto = (productPerishable.Weight / 100) / 12;

		Console.WriteLine($"Imposto São Paulo: {imposto}");

		return imposto;
	}
}