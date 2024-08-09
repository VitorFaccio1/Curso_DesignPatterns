namespace DesignPatterns.Creational_Patterns.Builder.Carros;

public class Mustang : Car
{
    public override void ChooseColor(string color)
    {
        Color = color;
    }

    public override void ChooseEngine(string engine)
    {
        Engine = engine;
    }

    public override void ChooseSeatsNumber(int seatsNumber)
    {
        SeatsNumber = seatsNumber;
    }

    public override void ChooseName(string name)
    {
        Name = name;
    }
}