module Math.Primality
  ( isPrime
  , primes
  , primeFactors
  , circularPrimes
  ) where
import Math.Combinatorics

isPrime :: Integer -> Bool
isPrime n = n > 1 &&
              foldr (\p r -> p*p > n || ((n `rem` p) /= 0 && r))
                True (2:[3,5..])
                
primes :: [Integer]
primes = filter isPrime [2..]

primeFactors :: Integer -> [Integer]
primeFactors n | n > 1 = go n (2:[3,5..])   -- or go n (2:[3,5..])
   where                               -- for one-off invocation
     go n ps@(p:t)
        | p*p > n    = [n]
        | r == 0     =  p : go q ps
        | otherwise  =      go n t
                where
                  (q,r) = quotRem n p

circularPrimes :: [Integer] -> [Integer]
circularPrimes [] = []
circularPrimes (x:xs)
    | all isPrime p = x :  circularPrimes xs
    | otherwise     = circularPrimes xs
    where
        p = circularPermutations x
