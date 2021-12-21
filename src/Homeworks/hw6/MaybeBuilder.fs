module hw6.MaybeBuilder

type MaybeBuilder() =
    member b.Bind(x, f) =
        match x with
        | Ok x -> f x
        | Error e -> Error e
    member b.Return x = Ok x