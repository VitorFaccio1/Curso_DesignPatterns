using DesignPatterns.Behavioral_Patterns.Command.Interfaces;
using DesignPatterns.Behavioral_Patterns.Command.Models;

namespace DesignPatterns.Behavioral_Patterns.Command.Commands;

public abstract class CommandBase : ICommand
{
    protected Editor _editor;
    private string _backup;

    public CommandBase(Editor editor)
    {
        _editor = editor;
    }

    public void SaveBackup()
    {
        _backup = _editor.Text;
    }

    public void Undo()
    {
        _editor.Text = _backup;
    }

    public abstract bool Execute();
}