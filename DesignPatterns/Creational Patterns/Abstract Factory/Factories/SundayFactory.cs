using DesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;
using DesignPatterns.Creational_Patterns.Abstract_Factory.Products;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory.Factories;

public class SundayFactory : IFactory
{
    public SundayFactory()
    {
        this.GetDailyRoutine();
    }

    public void GetDailyRoutine()
    {
        Console.WriteLine("Factory de Domingo criada!");
        new DietSunday().GetDiet();
        new WorkoutSunday().GetWorkout();
    }
}