namespace DesignPatterns.Creational_Patterns.Prototype;

public class Studio
{
    public Studio(string type, decimal value)
    {
        Type = type;
        Value = value;
    }

    public string Type { get; set; }

    public decimal Value { get; set; }

    public Studio Clone()
    {
        Console.WriteLine($"\n----Studio clonado----");

        Console.WriteLine(this.ToString());

        return this.MemberwiseClone() as Studio;
    }

    public override string ToString()
    {
        return $"\nTipo de Studio:{Type}\nValor do studio: {Value}";
    }
}