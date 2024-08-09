using DesignPatterns.Creational_Patterns.Builder.Carros;

namespace DesignPatterns.Creational_Patterns.Builder.Builders;

public abstract class CarBuilder
{
    protected Car car;

    public Car GetCar() { return car; }

    public abstract void ChooseColor();

    public abstract void ChooseEngine();

    public abstract void ChooseName();

    public abstract void ChooseSeatsNumber();
}