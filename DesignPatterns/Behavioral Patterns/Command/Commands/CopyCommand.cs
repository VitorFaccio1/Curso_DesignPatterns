using DesignPatterns.Behavioral_Patterns.Command.Models;

namespace DesignPatterns.Behavioral_Patterns.Command.Commands;

public class CopyCommand : CommandBase
{
    private string _clipboard;

    public CopyCommand(Editor editor) : base(editor) { }

    public override bool Execute()
    {
        _clipboard = _editor.GetSelection();
        Console.WriteLine($"Texto copiado: {_clipboard}");
        return false; 
    }
}