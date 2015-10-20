-- | By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
-- | What is the 10001st prime number?

import Math.Primality

main :: IO()
main = do
    let primes = filter isPrime [2..]
        answer = primes !! (10001-1)

    print answer
