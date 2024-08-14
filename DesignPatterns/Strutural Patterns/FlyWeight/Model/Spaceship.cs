namespace DesignPatterns.Strutural_Patterns.FlyWeight.Model;

public abstract class Spaceship
{
    protected string condition;

    protected string action;

    public string color { get; set; }

    public string size { get; set; }

    public abstract void Show(string color, string size);
}