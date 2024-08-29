namespace DesignPatterns.Behavioral_Patterns.Visitor.Interfaces;

public interface IProduct
{
	public string Name { get; set; }

	public double Weight { get; set; }

	public double GetTax(IVisitor visitor);
}