-- The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.
-- Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
-- NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.

import Math.Primality 
import Math.Integers
import Data.List


main :: IO()
main = do
    let ns = [n | n <- filter (>7) primes, truncable div n 10 && truncable mod n 10]
    let answer = sum $ take 11 ns
    print answer


-- | f = function to apply (mod or div)
-- | n = numerator
-- | d = denominator
-- note that adding not $ isPrime (f n d) = False as it's own guard / stopping 
-- condition did not improve performance
truncable :: (Integer -> Integer -> Integer) -> Integer -> Integer -> Bool
truncable f n d
    | d > n     = True
    | otherwise = isPrime (f n d) && truncable f n (d*10)


-- leftTruncable :: [Integer] -> Bool
-- leftTruncable [] = True
-- leftTruncable (x:xs) =  
--     isPrime n && leftTruncable xs 
--     where 
--         n = fromIntegerArray (x:xs)
       
-- rightTruncable :: [Integer] -> Bool
-- rightTruncable [] = True
-- rightTruncable (x:xs) = 
--     isPrime n && rightTruncable xs 
--     where 
--         n = fromIntegerArray $ reverse (x:xs)


-- pulled from the forum after my initial solution (for learning purposes)
fastSolution :: Integer
fastSolution = sum $ filter (>=10) $ concatMap list [2,3,5,7]

list :: Integer -> [Integer]
list n = filter isLeftTruncatable $ if isPrime n then n:ns else []
  where ns = concatMap (list . ((10*n) +)) [1,3,7,9]

isLeftTruncatable :: Integer -> Bool
isLeftTruncatable = all isPrime . map read . init . tail . tails . show