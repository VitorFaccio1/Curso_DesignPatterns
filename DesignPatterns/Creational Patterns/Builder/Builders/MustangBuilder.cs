using DesignPatterns.Creational_Patterns.Builder.Carros;

namespace DesignPatterns.Creational_Patterns.Builder.Builders;

public class MustangBuilder : CarBuilder
{
    public MustangBuilder()
    {
        car = new Mustang();
    }

    public override void ChooseColor()
    {
        car.ChooseColor("Preto");
    }

    public override void ChooseEngine()
    {
        car.ChooseEngine("V8 5.0");
    }

    public override void ChooseSeatsNumber()
    {
        car.ChooseSeatsNumber(4);
    }

    public override void ChooseName()
    {
        car.ChooseName("Mustang GT");
    }
}