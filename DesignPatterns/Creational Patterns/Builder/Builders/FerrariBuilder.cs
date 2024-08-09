namespace DesignPatterns.Creational_Patterns.Builder.Builders;

public class FerrariBuilder : CarBuilder
{
    public FerrariBuilder()
    {
        car = new Ferrari();
    }

    public override void ChooseColor()
    {
        car.ChooseColor("Vermelho");
    }

    public override void ChooseEngine()
    {
        car.ChooseEngine("V8 3.9");
    }

    public override void ChooseSeatsNumber()
    {
        car.ChooseSeatsNumber(2);
    }

    public override void ChooseName()
    {
        car.ChooseName("Ferrari 488");
    }
}