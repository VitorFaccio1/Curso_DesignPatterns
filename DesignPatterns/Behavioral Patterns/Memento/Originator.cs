namespace DesignPatterns.Behavioral_Patterns.Memento;

public class Originator
{
    private string _state;

    public string State
    {
        get { return _state; }
        set { _state = value; Console.WriteLine($"Estado atual do vídeo: {_state}"); }
    }

    public Snapshot CreateSnapshot() => new Snapshot(_state);

    public void Restore(Snapshot snapshot)
    {
        Console.WriteLine("Restaurando estado.....");

        State = snapshot.GetState();
    }
}