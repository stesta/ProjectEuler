module Math.Pythagorean where

-- | Euclid a = 2mn; b = m^2-n^2; c = m^2+n^2
triplets :: Integral a => a -> [[a]]
triplets l = [[a,b,c] | m <- [2..limit], n <- [1..(m-1)],
                        let a = 2*m*n,
                        let b = m^2 - n^2,
                        let c = m^2 + n^2,
                        a+b+c == l]
    where limit = floor . sqrt . fromIntegral $ l
