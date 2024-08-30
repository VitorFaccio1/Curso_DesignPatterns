using DesignPatterns.Behavioral_Patterns.Command.Models;

namespace DesignPatterns.Behavioral_Patterns.Command.Commands;

public class PasteCommand : CommandBase
{
    private string _clipboard;

    public PasteCommand(Editor editor, string clipboard) : base(editor)
    {
        _clipboard = clipboard;
    }

    public override bool Execute()
    {
        SaveBackup();
        _editor.ReplaceSelection(_clipboard);
        Console.WriteLine($"Texto colado: {_clipboard}");
        return true;
    }
}