namespace GraphQLTypeProvider

open FSharp.Data.GraphQL
open FSharp.Data.GraphQL.Types

module TestGraphQL =
    type Person =
        { FirstName: string
          LastName: string }

    let PersonType = Define.Object(
        name = "Person",
        fields = [
            Define.AutoField("firstName", String)
            Define.AsyncField("lastName", String, resolve = fun context person -> async { return person.LastName })
        ])
    let schema = Schema(query = PersonType)
    let executor = Executor(schema)
    let johnSnow = { FirstName = "John"; LastName = "Snow" }
    let reply = executor.AsyncExecute(Parser.parse "{ firstName, lastName }", johnSnow) |> Async.RunSynchronously
