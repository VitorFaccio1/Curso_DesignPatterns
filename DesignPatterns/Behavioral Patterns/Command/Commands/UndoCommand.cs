
using DesignPatterns.Behavioral_Patterns.Command.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Command.Commands;

public class UndoCommand : CommandBase
{
    private CommandHistory _history;

    public UndoCommand(CommandHistory history) : base(null)
    {
        _history = history;
    }

    public override bool Execute()
    {
        if (_history.Count > 0)
        {
            ICommand command = _history.Pop();
            command.Undo();
            Console.WriteLine("Última ação desfeita.");
        }

        return false;
    }
}