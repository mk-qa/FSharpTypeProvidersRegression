namespace DataTypeProvider

open FSharp.Data

//CSV Type Provider
module TestCVS =
    type Stocks = CsvProvider<"samples/test.csv">
    let msft = Stocks.Load(__SOURCE_DIRECTORY__ + "samples/test.csv").Cache()
    let firstRow = msft.Rows |> Seq.head
    let lastDate = firstRow.Date
    let lastOpen = firstRow.Open

    for row in msft.Rows do
      printfn "HLOC: (%A, %A, %A, %A)" row.High row.Low row.Open row.Close
    
