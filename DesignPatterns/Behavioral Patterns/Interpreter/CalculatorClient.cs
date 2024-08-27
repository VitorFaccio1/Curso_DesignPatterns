using DesignPatterns.Behavioral_Patterns.Interpreter.Calculator.Expressions;
using DesignPatterns.Behavioral_Patterns.Interpreter.Calculator.Models;

namespace DesignPatterns.Behavioral_Patterns.Interpreter.Calculator
{
    public class CalculatorClient
    {
        public void Calculate()
        {
            bool continueMenu = true;

            while (continueMenu)
            {
                var number1 = new Number(10);
                var number2 = new Number(50);

                var addExpression = new AddExpression(number1, number2);
                var subtractExpression = new SubtractExpression(number1, number2);

                Console.WriteLine($"Soma: {addExpression.Interpret()}\nSubtracao: {subtractExpression.Interpret()}");

                Console.WriteLine("\nDeseja entender o funcionamento do Interpreter novamente?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                Console.Write("Digite sua escolha: ");
                continueMenu = Convert.ToInt32(Console.ReadLine()) == 1;
            }
        }
    }
}