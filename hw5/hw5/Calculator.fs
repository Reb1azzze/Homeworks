module hw5.Calculator
open hw5
open Parser
    
    let Calculate (arg1 : decimal) (operation) (arg2 : decimal) =
        if arg2 = (decimal) 0  then
            Failure "Divide by zero is not allowed."
        else
            let result =
                match operation with
                |  "+" ->   (arg1 + arg2) 
                |  "-" ->   (arg1 - arg2)
                |  "*" ->   (arg1 * arg2)
                |  "/" ->   (arg1 / arg2)
            Success result