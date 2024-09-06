using DesignPatterns.Behavioral_Patterns.State.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.State.States;

public class Context
{
    private IState _state;

    public Context(IState state)
    {
        _state = state;
    }

    public IState State
    {
        get { return _state; }
        set { _state = value; Console.WriteLine($"Mudando para {_state.GetType().Name}"); }
    }

    public void Change()
    {
        _state.Action(this);
    }
}