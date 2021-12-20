module hw6.Parser
open op
let tryParseOperation operation =
    match operation with
    | "plus" -> Ok  Plus
    | "minus" -> Ok Minus
    | "mult" -> Ok Multiply
    | "divide" -> Ok Divide
    | _ ->   Error  $"Valid operation, supported operations are: plus minus mult divide"