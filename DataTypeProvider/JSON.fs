namespace DataTypeProvider

open FSharp.Data

//JSON Type Provider
module TestJSON =
    type Values = JsonProvider<""" [{"value":94 }, {"value":"Tomas" }] """>

    for item in Values.GetSamples() do 
      match item.Value.Number, item.Value.String with
      | Some num, _ -> printfn "Numeric: %d" num
      | _, Some str -> printfn "Text: %s" str
      | _ -> printfn "Some other value!"

