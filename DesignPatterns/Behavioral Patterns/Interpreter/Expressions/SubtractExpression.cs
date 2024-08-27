using DesignPatterns.Behavioral_Patterns.Interpreter.Calculator.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Interpreter.Calculator.Expressions;

public class SubtractExpression : IExpression
{
    private IExpression _leftExpression;
    private IExpression _rightExpression;

    public SubtractExpression(IExpression left, IExpression right)
    {
        _leftExpression = left;
        _rightExpression = right;
    }

    public double Interpret()
    {
        return _leftExpression.Interpret() - _rightExpression.Interpret();
    }
}