using DesignPatterns.Behavioral_Patterns.State.States;

namespace DesignPatterns.Behavioral_Patterns.State.Interfaces;

public interface IState
{
    public void Action(Context context);
}