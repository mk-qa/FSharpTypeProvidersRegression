namespace SQLTypeProviderCore

open FSharp.Data.Sql
open System

module TestPOSTGRESQL =
    [<Literal>]
    let private DefaultConnectionString = "User ID=usertest;Host=localhost;Port=5432;Database=testdb;Password=test"

    type private db =
        SqlDataProvider<Common.DatabaseProviderTypes.POSTGRESQL,
                        DefaultConnectionString,
                        UseOptionTypes=true>
    
    type DataContext = db.dataContext
