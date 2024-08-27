using DesignPatterns.Behavioral_Patterns.Template_Method.Model;
using Newtonsoft.Json;

namespace DesignPatterns.Behavioral_Patterns.Template_Method;

public class ConvertJSON : ProcessData
{
    public ConvertJSON(string json) : base(json)
    {
    }

    public override void ProcessJSON()
    {
        this.people = JsonConvert.DeserializeObject<List<Person>>(this.json);

        this.ShowValues();
    }
}