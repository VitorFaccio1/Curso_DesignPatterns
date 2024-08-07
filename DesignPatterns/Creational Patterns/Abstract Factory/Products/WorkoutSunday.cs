using DesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory.Products;

public class WorkoutSunday : IWorkout
{
    public WorkoutSunday()
    {
        this.GetWorkout();
    }

    public void GetWorkout()
    {
        Console.WriteLine("Treino de Domingo!");
    }
}