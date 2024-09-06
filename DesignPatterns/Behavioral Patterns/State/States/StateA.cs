using DesignPatterns.Behavioral_Patterns.State.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.State.States;

public class StateA : IState
{
    public void Action(Context context)
    {
        Console.WriteLine("Executando ações do Estado A"); 
        context.State = new StateB();
    }
}