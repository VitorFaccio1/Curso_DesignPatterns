namespace DesignPatterns.Behavioral_Patterns.Chain_of_Responsability;

public abstract class ExpenseHandler
{
    protected ExpenseHandler _nextHandler;

    public void SetNextHandler(ExpenseHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public abstract void HandleRequest(decimal amount);
}
