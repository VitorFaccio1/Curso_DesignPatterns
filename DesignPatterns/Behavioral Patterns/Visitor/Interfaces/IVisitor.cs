using DesignPatterns.Behavioral_Patterns.Visitor.Products;

namespace DesignPatterns.Behavioral_Patterns.Visitor.Interfaces;

public interface IVisitor
{
	//visita um produto e aplica a regra de calcular imposto

	double CalculteTaxProductPerishable(ProductPerishable productPerishable);

	double CalculteTaxProductNotPerishable(ProductNotPerishable productNotPerishable);
}