using System;

namespace hw1
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var InputCode = Parser.CheckInput( args,
                out var firstArg,
                out var operation,
                out var secondArg);
            if (InputCode != 0) return InputCode;
            var result = Calculator.Calculate( firstArg, operation, secondArg);
            Console.WriteLine($"{firstArg}{operation}{secondArg}={result}");
            return 0;
        }
    }
}