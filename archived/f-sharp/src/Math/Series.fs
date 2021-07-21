module Series 

let fibonacci =  
    let rec f a b = 
      seq { yield a
            yield! f b (a+b) }
    f 1 1 |> Seq.cache