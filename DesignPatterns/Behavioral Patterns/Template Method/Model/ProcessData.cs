namespace DesignPatterns.Behavioral_Patterns.Template_Method.Model;

public abstract class ProcessData
{
    protected List<Person> people;
    protected string json;
    protected string xml;

    protected ProcessData(string json = "", string xml = "")
    {
        if (!string.IsNullOrEmpty(json))
            this.json = json;

        if (!string.IsNullOrEmpty(xml))
            this.xml = xml;

        people = new List<Person>();
    }

    public virtual void ProcessXML()
    {

    }

    public virtual void ProcessJSON()
    {

    }

    protected void ShowValues()
    {
        foreach (var person in people)
        {
            Console.WriteLine(new String('-', 40));

            Console.WriteLine($"\nCliente: {person.Name}\n");

            foreach (var action in person.Actions)
            {
                Console.WriteLine(new String('-', 30));

                Console.WriteLine($"Sigla: {action.Acronym}\nValor unitario: {action.UnitValue.ToString("C")}" +
                    $"\nQuantidade: {action.Quantity}\nValor total: {action.UnitValue * action.Quantity}");
            }
        }
    }
}