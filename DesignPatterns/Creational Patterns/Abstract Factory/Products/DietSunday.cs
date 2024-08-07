using DesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;

namespace DesignPatterns.Creational_Patterns.Abstract_Factory.Products
{
    public class DietSunday : IDiet
    {
        public DietSunday()
        {
            this.GetDiet();
        }

        public void GetDiet()
        {
            Console.WriteLine("Dieta de Domingo!");
        }
    }
}