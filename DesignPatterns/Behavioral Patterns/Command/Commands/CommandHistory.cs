
using DesignPatterns.Behavioral_Patterns.Command.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Command.Commands;

public class CommandHistory
{
    private List<ICommand> _history = new();

    public void Push(ICommand command)
    {
        _history.Add(command);
    }

    public ICommand Pop()
    {
        if (_history.Count == 0)
            return null;

        _history.RemoveAt(_history.Count - 1);

        return _history[^1];
    }

    public int Count => _history.Count;
}