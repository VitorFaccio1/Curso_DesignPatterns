using DesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory.Products;

public class DietMonday : IDiet
{
    public DietMonday()
    {
        this.GetDiet();
    }

    public void GetDiet()
    {
        Console.WriteLine("Dieta de Segunda!");
    }
}