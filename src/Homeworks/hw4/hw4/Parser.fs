module hw4.Parser

open System

let SupportedOperations = [|"+"; "-"; "*"; "/"|]

let ParseArgs (args: string[]) (val1: byref<int>) (operation: outref<string>) (val2: outref<int>) =
    let isval1correct = Int32.TryParse(args.[0], &val1)
    let isval2correct = Int32.TryParse(args.[2], &val2)
    operation <- args.[1]
    if (isval1correct && isval2correct) = false then
        printf $"{args.[0]}{args.[1]}{args.[2]} is not a valid calculate syntax"
        1
    else if Array.contains operation SupportedOperations = false then
        printf $"{args.[0]}{args.[1]}{args.[2]} Supported operations are + - * /"
        2
    else 0
 