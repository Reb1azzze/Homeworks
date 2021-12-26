using System.Collections.Concurrent;
using System.Linq.Expressions;
using hw9.Infrastructure;

namespace hw13.Infrastructure
{
    public class InMemoryCachingCalculatorVisitor : ICalculatorVisitor
    {
        private readonly ICalculatorVisitor _visitor;
        private static readonly ConcurrentDictionary<string, double> Cache = new();

        public InMemoryCachingCalculatorVisitor(ICalculatorVisitor visitor)
        {
            _visitor = visitor;
        }

        public Expression Visit(Expression node)
        {
            var expressionString = node.ToString();
            if (Cache.ContainsKey(expressionString))
            {
                return Expression.Constant(Cache[expressionString]);
            }

            var result = _visitor.Visit(node) as ConstantExpression;
            Cache[expressionString] = (double) result!.Value!;

            return result;
        }
    }
}