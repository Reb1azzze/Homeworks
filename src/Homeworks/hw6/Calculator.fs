module hw6.Calculator

let Calculate (val1: decimal, operation, val2: decimal) =
    match operation with
    | divide ->
        match val2 with
        | 0m -> Error ErrorType.DivideByZero
        | _ ->  val1 / val2 |> Ok 
    | plus -> val1 + val2 |> Ok
    | minus -> val1 - val2 |> Ok
    | multiply -> val1 * val2 |> Ok