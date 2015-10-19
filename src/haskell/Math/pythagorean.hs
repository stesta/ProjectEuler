module Math.Pythagorean where

-- | Euclid a = 2mn; b = m^2-n^2; c = m^2+n^2
solveTriplet :: Int -> Int -> (Int, Int, Int)
solveTriplet m n = ((2*m*n),(m^2 - n^2),(m^2 + n^2))