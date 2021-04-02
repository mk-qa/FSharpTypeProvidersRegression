module HtmlProvider

open System.IO

open BasicProvider.Provided


type Generative8 = BasicProvider.GenerativeProvider<20>
                          
let ``Can access properties of generative provider 4`` () =
    let obj = Generative8()
    (obj.Property1, 1)
    (obj.Property2, 2)          
    (obj.Property3, 3)            
    (obj.Property17, 4)                  
                    



