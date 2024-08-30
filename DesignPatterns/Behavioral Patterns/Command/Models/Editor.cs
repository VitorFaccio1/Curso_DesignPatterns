namespace DesignPatterns.Behavioral_Patterns.Command.Models;

public class Editor
{
    public string Text { get; set; } = "";

    public string GetSelection() => Text; 

    public void DeleteSelection() => Text = ""; 

    public void ReplaceSelection(string text) => Text = text; 
}