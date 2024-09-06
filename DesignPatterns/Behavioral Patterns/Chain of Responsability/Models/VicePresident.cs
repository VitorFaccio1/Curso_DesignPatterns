namespace DesignPatterns.Behavioral_Patterns.Chain_of_Responsability.Models;

public class VicePresident : ExpenseHandler
{
    public override void HandleRequest(decimal amount)
    {
        if (amount <= 10000)
        {
            Console.WriteLine("Vice-presidente aprovou a despesa de R$" + amount);
        }
        else
        {
            Console.WriteLine("A despesa de R$" + amount + " requer uma reunião executiva!");
        }
    }
}