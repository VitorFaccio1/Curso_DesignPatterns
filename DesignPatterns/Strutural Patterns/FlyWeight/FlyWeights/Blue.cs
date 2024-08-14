using DesignPatterns.Strutural_Patterns.FlyWeight.Model;

namespace DesignPatterns.Strutural_Patterns.FlyWeight.FlyWeights;

public class Blue : Spaceship
{
    public Blue()
    {
        condition = "flying";
        action = "firing";
    }

    public override void Show(string color, string size)
    {
        this.color = color;
        this.size = size;

        Console.WriteLine($"\nNave {this.size} e {this.color} e {condition} e {action}");
    }
}