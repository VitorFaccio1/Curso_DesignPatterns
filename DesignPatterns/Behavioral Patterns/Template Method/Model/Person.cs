namespace DesignPatterns.Behavioral_Patterns.Template_Method.Model;

public class Person
{
    public Person()
    {

    }

    public string Name { get; set; }

    public string Cpf { get; set; }

    public List<Action> Actions { get; set; }
}