-- The first two consecutive numbers to have two distinct prime factors are: 
-- 14 = 2 × 7
-- 15 = 3 × 5

-- The first three consecutive numbers to have three distinct prime factors are: 
-- 644 = 2^2 × 7 × 23
-- 645 = 3 × 5 × 43
-- 646 = 2 × 17 × 19.

-- Find the first four consecutive integers to have four distinct prime factors. What is the first of these numbers?

import Math.Primality
import Data.List (nub)


problem_0047 :: Integer
problem_0047 = head [n | n <- [2..] 
                          , let n1 = uniqueFactors n
                          , let n2 = uniqueFactors (n+1)
                          , let n3 = uniqueFactors (n+2)
                          , let n4 = uniqueFactors (n+3)
                          , all (==4) [n1,n2,n3,n4]]


uniqueFactors :: Integer -> Int
uniqueFactors = length . nub . primeFactors
