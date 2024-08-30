namespace DesignPatterns.Behavioral_Patterns.Command.Interfaces;

public interface ICommand
{
    bool Execute();

    void Undo();
}