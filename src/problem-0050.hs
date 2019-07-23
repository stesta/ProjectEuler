-- The prime 41, can be written as the sum of six consecutive primes:

-- 41 = 2 + 3 + 5 + 7 + 11 + 13
-- This is the longest sum of consecutive primes that adds to a prime below one-hundred.

-- The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.

-- Which prime, below one-million, can be written as the sum of the most consecutive primes?

import Math.Primality (primes, isPrime)
import Data.List (find)
import Data.Maybe (mapMaybe)

main :: IO ()
main = print $ 
    head $ mapMaybe (findPrime . consecSums) [maxconsec,maxconsec-1..2]

maxconsec :: Int
maxconsec = length . takeWhile (<1000000) $ sums

findPrime :: [Integer] -> Maybe Integer
findPrime = find isPrime . takeWhile (<1000000)

consecSums :: Int -> [Integer]
consecSums w = zipWith (-) (drop w sums) sums

sums :: [Integer]
sums = scanl1 (+) primes