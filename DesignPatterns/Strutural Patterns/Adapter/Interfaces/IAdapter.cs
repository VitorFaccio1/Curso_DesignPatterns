namespace DesignPatterns.Strutural_Patterns.Adapter.Interfaces
{
    public interface IAdapter
    {
        public string ExecuteRotineBillsToPay(string month);

        public string ExecuteRotineBillsToRecieve(string month);
    }
}