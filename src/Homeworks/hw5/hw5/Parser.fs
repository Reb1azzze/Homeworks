module hw5.Parser
type Result<'a> =
| Success of 'a
| Failure of string

type ResultBuilder() =
    let bind f res =
        match res with
        | Success x -> f x
        | Failure errs -> Failure errs
    member this.Return x = x
    member this.ReturnFrom x = Success x
    member this.Bind(x,f) = bind f x

let result = new ResultBuilder()        
let TryParseArguments (args : string[]) =
        let supportedOperation operation =
            match operation with
            | "+" -> Success "+"
            | "-" -> Success "-"
            | "*"  -> Success "*"
            | "/"  -> Success "/"
            | _ -> Failure $"Not allowed operation."
            
        let parseVal x =
            try Success (x |> decimal) with
            | _ -> Failure $"Not allowed argument."
        parseVal args.[0], supportedOperation args.[1], parseVal args.[2]