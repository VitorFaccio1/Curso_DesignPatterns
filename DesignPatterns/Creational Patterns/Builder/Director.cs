using DesignPatterns.Creational_Patterns.Builder.Builders;

namespace DesignPatterns.Creational_Patterns.Builder;

public class Director
{
    private readonly CarBuilder carBuilder;

    public void DoCar(CarBuilder carBuilder)
    {
        carBuilder.ChooseSeatsNumber();
        carBuilder.ChooseEngine();
        carBuilder.ChooseColor();
        carBuilder.ChooseName();
    }

    public void DoCarWithoutColor(CarBuilder carBuilder)
    {
        carBuilder.ChooseSeatsNumber();
        carBuilder.ChooseEngine();
        carBuilder.ChooseName();
    }
}