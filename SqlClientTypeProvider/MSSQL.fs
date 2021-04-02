namespace SqlClientTypeProvider

open FSharp.Data

module TestMSSQL =
    [<Literal>]
    let connectionString = 
        @"Server=localhost\SQLExpress;Database=AdventureWorks2017;Trusted_Connection=True;"
        
    do
    use cmd = new SqlCommandProvider<"
        SELECT TOP(@topN) FirstName, LastName, SalesYTD 
        FROM Sales.vSalesPerson
        WHERE CountryRegionName = @regionName AND SalesYTD > @salesMoreThan 
        ORDER BY SalesYTD
        " , connectionString>(connectionString)

    cmd.Execute(topN = 3L, regionName = "United States", salesMoreThan = 1000000M) |> printfn "%A"
        
    