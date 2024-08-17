using DesignPatterns.Strutural_Patterns.Composite.Model;

namespace DesignPatterns.Strutural_Patterns.Composite;

public class ProductLeaf : ComponentModel
{
    private string _name;

    private double _value;

    public ProductLeaf(string name, double value)
    {
        _name = name;
        _value = value;
    }

    public override double Operation()
    {
        Console.WriteLine($"Produto: {_name}\nValor: {_value.ToString("C")}");
        Console.WriteLine(new string('-', 40));

        return _value;
    }

    public override void Add(params ComponentModel[] components)
    {
        Console.WriteLine("Não é possivel adicionar itens em um objeto do tipo Leaf");
    }

    public override void Remove(ComponentModel component)
    {
        Console.WriteLine("Não é possivel remover itens em um objeto do tipo Leaf");
    }

    public override ComponentModel GetChild(int index)
    {
        Console.WriteLine("Não é possivel obter itens em um objeto do tipo Leaf");

        return null;
    }
}