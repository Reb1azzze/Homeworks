module hw6.Calculator

let inline Calculate val1 operation val2 =
    match operation with
    | CalculatorOperation.Plus -> val1 + val2
    | CalculatorOperation.Multiply -> val1 * val2
    | CalculatorOperation.Minus -> val1 - val2
    | CalculatorOperation.Divide -> val1 / val2