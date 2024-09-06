namespace DesignPatterns.Behavioral_Patterns.Memento;

public class Snapshot
{
    private string _state;

    public Snapshot(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }
}