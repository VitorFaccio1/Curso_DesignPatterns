namespace DesignPatterns.Behavioral_Patterns.Template_Method.Model;

public class Action
{
    public Action()
    {

    }

    public Action(string acronym, int quantity, double unitValue)
    {
        Acronym = acronym;
        Quantity = quantity;
        UnitValue = unitValue;
    }

    public string Acronym { get; set; }

    public int Quantity { get; set; }

    public double UnitValue { get; set; }
}