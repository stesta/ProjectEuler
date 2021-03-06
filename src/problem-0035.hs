-- The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
-- There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
-- How many circular primes are there below one million?

import Math.Primality


-- can be improved: circular primes (other than 2) can contain only 1,3,7,9
main :: IO ()
main = print $ 
    length . circularPrimes . takeWhile (<1000000) $ primes
