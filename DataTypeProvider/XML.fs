namespace DataTypeProvider

open FSharp.Data

//XML Type Provider
module TestXML1 =
    type AuthorAlt = XmlProvider<"<author><name>Karl Popper</name><born>1902</born></author>">
    let doc = "<author><name>Paul Feyerabend</name><born>1924</born></author>"
    let sampleAlt = AuthorAlt.Parse(doc)

    printfn "%s (%d)" sampleAlt.Name sampleAlt.Born

module TestXML2 =
    type Authors = XmlProvider<"samples/test.xml">
    let topic = Authors.Parse("authors")

    printfn "%s" topic.Topic
    for author in topic.Authors do
      printf " - %s" author.Name 
      author.Born |> Option.iter (printf " (%d)")
      printfn ""
