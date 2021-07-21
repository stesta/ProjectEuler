module Primality

let isPrime n = 
    let sqrt' = (float >> sqrt >> int) n   
    match n with 
    | n when n <= 1 -> false
    | _ -> [2 .. sqrt'] |> List.forall (fun x -> n % x <> 0)


// credit:
// http://mark-dot-net.blogspot.com/2013/11/finding-prime-factors-in-f.html
// https://jeremybytes.blogspot.com/2016/07/getting-prime-factors-in-f-with-good.html
let factors n = 
    let rec f n x a =
        if x = n then
            x::a
        elif n % x = 0L then
            f (n/x) x (x::a)
        else
            f n (x+1L) a
    
    f n 2L []
