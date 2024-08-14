using DesignPatterns.Strutural_Patterns.FlyWeight.FlyWeights;
using DesignPatterns.Strutural_Patterns.FlyWeight.Model;

namespace DesignPatterns.Strutural_Patterns.FlyWeight;

public class FlyWeightFactory
{
    private Dictionary<string, Spaceship> spaceships = new();

    public Spaceship GetSpaceship(string color)
    {
        if (spaceships.ContainsKey(color))
            return spaceships[color];

        Spaceship spaceship = null;

        switch (color)
        {
            case "blue":
                spaceship = new Blue();
                break;
            case "red":
                spaceship = new Red();
                break;
            default:
                break;
        }

        spaceships.Add(color, spaceship);

        return spaceship;
    }
}