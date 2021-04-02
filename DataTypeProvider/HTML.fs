namespace DataTypeProvider

open FSharp.Data

//HTML Type Provider
module TestHTML =
    let [<Literal>] DrWho = "https://en.wikipedia.org/wiki/List_of_Doctor_Who_episodes_(1963%E2%80%931989)"
    let doctorWho = new HtmlProvider<DrWho>()
    let viewersByDoctor = 
      doctorWho.Tables.``Season 1 (1963-1964) Edit``.Rows
      |> Seq.groupBy (fun season -> season.``Directed by``)
      |> Seq.map (fun (doctor, seasons) -> 
          let averaged = 
            seasons 
            |> Seq.averageBy (fun season -> 
                season.``UK viewers (millions)``)
          doctor, averaged)
      |> Seq.toArray 