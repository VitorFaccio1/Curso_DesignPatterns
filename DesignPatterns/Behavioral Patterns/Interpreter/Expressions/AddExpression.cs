using DesignPatterns.Behavioral_Patterns.Interpreter.Calculator.Interfaces;

namespace DesignPatterns.Behavioral_Patterns.Interpreter.Calculator.Expressions
{
    public class AddExpression : IExpression
    {
        private IExpression _leftExpression;
        private IExpression _rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            _leftExpression = left;
            _rightExpression = right;
        }

        public double Interpret()
        {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }
}