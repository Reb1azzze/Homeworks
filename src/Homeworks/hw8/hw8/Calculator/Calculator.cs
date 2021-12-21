using System.Globalization;
using hw8.Interface;

namespace hw8.Calculator
{
    public class Calculator : ICalculator
    {
        public string Plus(double val1, double val2)
            => (val1 + val2).ToString(CultureInfo.InvariantCulture);

        public string Minus(double val1, double val2)
            => (val1 - val2).ToString(CultureInfo.InvariantCulture);

        public string Multiply(double val1, double val2)
            => (val1 * val2).ToString(CultureInfo.InvariantCulture);

        public string Divide(double val1, double val2) =>
            val2 == 0
                ? "divide by zero"
                : (val1 / val2).ToString(CultureInfo.InvariantCulture);
    }
}