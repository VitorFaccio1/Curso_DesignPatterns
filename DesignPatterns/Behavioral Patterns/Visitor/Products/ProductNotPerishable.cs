using DesignPatterns.Behavioral_Patterns.Visitor.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Visitor.Products;

public class ProductNotPerishable : IProduct
{
	public ProductNotPerishable(string name, double weight)
	{
		Name = name;
		Weight = weight;
	}

	public string Name { get; set; }

	public double Weight { get; set; }

	public double GetTax(IVisitor visitor)
	{
		return visitor.CalculteTaxProductNotPerishable(this);
	}
}