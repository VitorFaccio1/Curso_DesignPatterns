namespace DesignPatterns.Creational_Patterns.Prototype;

public class StudiosManager
{
    private Dictionary<string, Studio> _studioModels = new();

    public Studio this[string key]
    {
        get
        {
            return _studioModels.ContainsKey(key)
                ? _studioModels[key]
                : throw new Exception();
        }
        set { _studioModels[key] = value; }
    }
}