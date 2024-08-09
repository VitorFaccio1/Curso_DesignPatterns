using DesignPatterns.Creational_Patterns.Builder.Carros;

namespace DesignPatterns.Creational_Patterns.Builder.Builders
{
    public class Ferrari : Car
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
}