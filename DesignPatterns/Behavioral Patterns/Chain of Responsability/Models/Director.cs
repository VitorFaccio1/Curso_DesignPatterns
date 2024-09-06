namespace DesignPatterns.Behavioral_Patterns.Chain_of_Responsability.Models;

public class Director : ExpenseHandler
{
    public override void HandleRequest(decimal amount)
    {
        if (amount <= 5000)
        {
            Console.WriteLine("Diretor aprovou a despesa de R$" + amount);
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(amount);
        }
    }
}