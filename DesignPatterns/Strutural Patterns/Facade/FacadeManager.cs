using DesignPatterns.Strutural_Patterns.Facade.ComplexityEnviroment;

namespace DesignPatterns.Strutural_Patterns.Facade;

public class FacadeManager
{
	public void ExecuteComplexity()
	{
		bool continueMenu = true;

		while (continueMenu)
		{
			Console.Clear();

			NorthZone northZone = new();
			SouthZone southZone = new();

			CloudComputing cloudComputing = new();

			var south = southZone.ExecuteRotineSalesLost(DateTime.Now);
			var north = northZone.ExecuteRotineSalesLost(DateTime.Now);

			cloudComputing.GenerateRelatoryWinsLoss(south, north);

			Console.WriteLine("\nDeseja gerar relatorio novamente??");
			Console.WriteLine("1 - Sim");
			Console.WriteLine("2 - Não");
			continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
		}
	}
}