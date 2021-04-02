namespace SQLTypeProvider

open FSharp.Data.Sql

module TestMSSQL = 
    let [<Literal>] connString = "Server=localhost\SQLExpress;Database=TestDB;Trusted_Connection=True;"
    type sql =
        SqlDataProvider<
            Common.DatabaseProviderTypes.MSSQLSERVER,
            connString>

    let ctx = sql.GetDataContext()
 