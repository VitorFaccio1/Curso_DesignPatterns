using DesignPatterns.Behavioral_Patterns.Command.Commands;
using DesignPatterns.Behavioral_Patterns.Command.Interfaces;
using DesignPatterns.Behavioral_Patterns.Command.Models;

namespace DesignPatterns.Behavioral_Patterns.Command;

public class Application
{
    private CommandHistory _history = new();
    private Editor _editor = new();
    private string _clipboard = "";

    public void ExecuteCommand(ICommand command)
    {
        if (command.Execute())
        {
            _history.Push(command);
        }
    }

    public void Copy() => ExecuteCommand(new CopyCommand(_editor));

    public void Cut() => ExecuteCommand(new CutCommand(_editor));

    public void Paste() => ExecuteCommand(new PasteCommand(_editor, _clipboard));

    public void Undo() => ExecuteCommand(new UndoCommand(_history));

    public void SetClipboard(string text)
    {
        Console.WriteLine($"Texto inserido: {text}");

        _clipboard = text;
    }
}