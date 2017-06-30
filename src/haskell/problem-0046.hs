-- It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.
 
-- 9 = 7 + 2×1^2
-- 15 = 7 + 2×2^2
-- 21 = 3 + 2×3^2
-- 25 = 7 + 2×3^2
-- 27 = 19 + 2×2^2
-- 33 = 31 + 2×1^2

-- It turns out that the conjecture was false. 
-- What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?

import Math.Primality

oddComposites :: [Integer]
oddComposites = [n | n <- [9..], odd n, not $ isPrime n]


squares :: [Integer]
squares = [n^2 | n <- [1..]]


isPrimeTimesSquare :: Integer -> [(Integer, Integer)]
isPrimeTimesSquare n = [(p,s) | p <- takeWhile (<n) primes
                              , s <- takeWhile (<n) squares
                              , p + (2*s) == n]
                                

main :: IO ()
main = do 
    let answer = head [oc | oc <- oddComposites, null . isPrimeTimesSquare $ oc]
    print answer