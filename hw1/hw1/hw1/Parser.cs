using System;
using System.Collections.Generic;

namespace hw1
{
    public class Parser
    {
        public static int CheckArgumentsLength(string[] args)
        {
            if (args.Length == 3) return 0;
            Console.WriteLine("The program needs 3 arguments");
            return 3;
        }
        public static int CheckInput(string[] args, out double firstArg,
            out string operation,
            out double secondArg)
        {
            var isValidArg1 = double.TryParse(args[0], out firstArg);
            operation = args[1];
            var isValidArg2 = double.TryParse(args[2], out secondArg);
            List<string> validOperations = new List<string>(){"/", "*", "+", "-"};
            if (!isValidArg1 || !isValidArg2)
            {
                Console.WriteLine("Entered arguments are not correct");
                return 1;
            }

            if (!validOperations.Contains(operation))
            {
                Console.WriteLine("Entered Operation is not supported");
                return 2;
            }

            return 0;
        }
    }
}