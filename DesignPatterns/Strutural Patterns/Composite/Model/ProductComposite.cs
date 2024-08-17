namespace DesignPatterns.Strutural_Patterns.Composite.Model;

public class ProductComposite : ComponentModel
{
    private List<ComponentModel> _components;

    public ProductComposite()
    {
        _components = new();
    }

    public override double Operation()
    {
        double totalValue = 0;

        for (int i = 0; i < _components.Count; i++)
        {
            var component = _components[i];

            totalValue += component.Operation();
        }

        return totalValue;
    }

    public override void Add(params ComponentModel[] components)
    {
        _components.AddRange(components);
    }

    public override void Remove(ComponentModel component)
    {
        _components.Remove(component);
    }

    public override ComponentModel GetChild(int index)
    {
        if (_components.Count == 0)
        {
            Console.WriteLine("Não possui produtos adicionados");

            return null;
        }

        return _components[index];
    }
}