using System;
using hw8.Calculator;
using hw8.Interface;
using Microsoft.AspNetCore.Mvc;

namespace hw8.Controllers
{
    public class CalculatorController : Controller
    {
        public string Calculate([FromServices] ICalculator calculator,
            string val1,
            string operation,
            string val2)
        {
            var isDouble1 = double.TryParse(val1, out var v1);
            var isDouble2 = double.TryParse(val2, out var v2);
            if (!isDouble1 || !isDouble2) return $"wrong args";

            var isOperation = Enum.TryParse<Operation>(operation, true, out var op);
            if (!isOperation)
                return $"plus, minus, multiply или divide";

            return op switch
            {
                Operation.Plus => calculator.Plus(v1, v2),
                Operation.Minus => calculator.Minus(v1, v2),
                Operation.Multiply => calculator.Multiply(v1, v2),
                Operation.Divide => calculator.Divide(v1, v2),
            };
        }

        public IActionResult Index()
        {
            return Content("'/calculator/calculate?val1= &operation= &val2=");
        }
    }
}