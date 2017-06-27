module Math.Pythagorean where

-- | Euclid a = m^2-n^2; b = 2mn; c = m^2+n^2

triples :: Integral a => a -> [[a]]
triples l = [[a,b,c] 
                | n <- [1..limit], m <- [n+1..limit],
                  let a = m^2 - n^2,
                  let b = 2*m*n,
                  let c = m^2 + n^2,
                  a+b+c == l]
    where limit = floor . sqrt . fromIntegral $ l

triplesScaled :: Integral a => a -> [[a]]
triplesScaled l = [[a*factor,b*factor,c*factor] 
                    | n <- [1..limit], m <- [n+1..limit],
                      even n || even m,
                      gcd n m == 1,
                      let a = m^2 - n^2,
                      let b = 2*m*n,
                      let c = m^2 + n^2,
                      l `mod` (a+b+c) == 0,
                      let factor = l `div` (a+b+c)]
    where limit = floor . sqrt . fromIntegral $ l
