namespace DesignPatterns.Behavioral_Patterns.Chain_of_Responsability.Models;

public class Manager : ExpenseHandler
{
    public override void HandleRequest(decimal amount)
    {
        if (amount <= 1000)
        {
            Console.WriteLine("Gerente aprovou a despesa de R$" + amount);
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(amount);
        }
    }
}