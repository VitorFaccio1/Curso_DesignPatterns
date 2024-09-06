using DesignPatterns.Behavioral_Patterns.State.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.State.States;

public class StateB : IState
{
    public void Action(Context context)
    {
        Console.WriteLine("Executando ações do Estado B");
        context.State = new StateA();
    }
}