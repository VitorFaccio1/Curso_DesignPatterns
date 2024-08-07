using DesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;
using DesignPatterns.Creational_Patterns.Abstract_Factory.Products;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory.Factories;

public class MondayFactory : IFactory
{
    public MondayFactory()
    {
        this.GetDailyRoutine();
    }

    public void GetDailyRoutine()
    {
        Console.WriteLine("Factory de Segunda criada!");
        new DietMonday().GetDiet();
        new WorkoutMonday().GetWorkout();
    }
}