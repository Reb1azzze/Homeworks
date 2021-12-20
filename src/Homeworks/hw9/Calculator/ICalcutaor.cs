namespace hw9.Calculator
{
    public interface ICalculator
    {
        public Result<string, string> Calculate(string expression);
    }
}