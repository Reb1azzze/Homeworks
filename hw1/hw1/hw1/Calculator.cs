namespace hw1
{
    public class Calculator
    {
        public static double Calculate(double firstarg, string operation, double secondarg)
        {
            double result = operation switch
            {
                "+" => firstarg + secondarg,
                "-" => firstarg - secondarg,
                "*" => firstarg * secondarg,
                "/" => (secondarg == 0) ? 0 : firstarg / secondarg,
                _ => 0
            };
            return result;
        }
    }
}