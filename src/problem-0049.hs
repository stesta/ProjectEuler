-- The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: (i) each of the three terms are prime, and, (ii) each of the 4-digit numbers are permutations of one another.

-- There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but there is one other 4-digit increasing sequence.

-- What 12-digit number do you form by concatenating the three terms in this sequence?

import Math.Combinatorics (isPermutation)
import Math.Primality (isPrime)

main :: IO ()
main = print $
    [(x,y,z) | x <- fourDigitPrimes
             , y <- fourDigitPrimes
             , y > x && x /= y && isPermutation x y
             , let z = y + (y-x) 
             , isPermutation x z && isPrime z]

fourDigitPrimes :: [Integer]
fourDigitPrimes = filter (isPrime) [1000..9999]