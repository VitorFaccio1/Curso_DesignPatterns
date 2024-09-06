namespace DesignPatterns.Behavioral_Patterns.Memento;

public class CareTaker
{
    private Snapshot _snapshot;

    public void AddSnapshot(Snapshot snapshot)
    {
        _snapshot = snapshot;
    }

    public Snapshot GetSnapshot() => _snapshot;
}