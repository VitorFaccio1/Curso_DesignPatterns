using DesignPatterns.Creational_Patterns.Factory_Method;

Console.WriteLine("Selecione o design pattern que deseja entender: " +
    "\n-------Creational Patterns-------" +
    "\n1)Factory Method");

Console.Write("\nDigite a opção que deseja: ");

var designPatternOption = Convert.ToInt32(Console.ReadLine());

while (designPatternOption != 0)
{
    switch (designPatternOption)
    {
        case 1: 
            new AnimalClient().CreateAnimal();
            break;
        default:
            break;
    }
}