using DesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory.Products;

public class WorkoutMonday : IWorkout
{
    public WorkoutMonday()
    {
        this.GetWorkout();
    }

    public void GetWorkout()
    {
        Console.WriteLine("Treino de Segunda!");
    }
}