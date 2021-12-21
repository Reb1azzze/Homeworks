using System.Linq;
using hw11.Services.Calculator;
using hw11.Services.Database;

namespace hw11.Services.Cash
{
    public class CashedCalculator : ICalculator
    {
        private readonly ICalculator _calculator;
        private readonly ApplicationContext _cashedExpression;

        public CashedCalculator(ICalculator calculator, ApplicationContext cashedExpression)
        {
            _calculator = calculator;
            _cashedExpression = cashedExpression;
        }

        public string Calculate(string expression)
        {
            var expressionWithoutSpace = expression?.Replace(" ", "");
            var possibleResult = _cashedExpression.CalculatingExpressions
                .FirstOrDefault(exp => exp.Expression == expressionWithoutSpace)?.Result;
            if (possibleResult is not null)
                return possibleResult;

            var result = _calculator.Calculate(expression);

            var calculatingExpression = new CalculatingExpression
            {
                Expression = expressionWithoutSpace,
                Result = result
            };
            _cashedExpression.Add(calculatingExpression);
            _cashedExpression.SaveChanges();
            return result;
        }
    }
}