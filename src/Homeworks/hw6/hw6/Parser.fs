module hw6.Parser
open hw6
open Input
let TryParseOperationInput (problem:Input) =
    match problem.Operation with
    | "Plus" -> Ok CalculatorOperation.Plus
    | "Multiply" -> Ok CalculatorOperation.Multiply
    | "Minus" -> Ok CalculatorOperation.Minus
    | "Divide" -> Ok CalculatorOperation.Divide
    | _ -> Error "Not allowed Operation." 