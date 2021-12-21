module hw6.Calculator

let tryCalculate (val1: decimal) operation (val2:decimal) =
    match operation with
    |plus -> Ok (val1 + val2)
    |minus -> Ok (val1 - val2)
    |multiply-> Ok (val1 * val2)
    |divide -> match val2 with
                    | 0m -> Error "Division by zero is not possible"
                    | _ -> Ok (val1 / val2)