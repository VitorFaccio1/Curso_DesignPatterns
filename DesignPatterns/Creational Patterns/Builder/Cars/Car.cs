namespace DesignPatterns.Creational_Patterns.Builder.Carros;

public abstract class Car
{
    public string Color { get; protected set; } //protected pois, so quem herda vai poder setar valores, quem nao herda so le.

    public int SeatsNumber { get; protected set; }

    public string Engine { get; protected set; }

    public string Name { get; protected set; }

    public abstract void ChooseColor(string color);

    public abstract void ChooseName(string name);

    public abstract void ChooseEngine(string motor);

    public abstract void ChooseSeatsNumber(int seatsNumber);

    public Car GetCar()
    {
        return this;
    }
}