using DesignPatterns.Behavioral_Patterns.Command.Models;

namespace DesignPatterns.Behavioral_Patterns.Command.Commands;

public class CutCommand : CommandBase
{
    public CutCommand(Editor editor) : base(editor) { }

    public override bool Execute()
    {
        SaveBackup();
        string selection = _editor.GetSelection();
        _editor.DeleteSelection();
        Console.WriteLine($"Texto cortado: {selection}");
        return true;
    }
}