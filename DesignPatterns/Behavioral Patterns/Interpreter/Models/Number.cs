using DesignPatterns.Behavioral_Patterns.Interpreter.Calculator.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Interpreter.Calculator.Models;

public class Number : IExpression
{
    private int _number;

    public Number(int number)
    {
        _number = number;
    }

    public double Interpret()
    {
        return _number;
    }
}