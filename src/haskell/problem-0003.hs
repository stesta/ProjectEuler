-- | The prime factors of 13195 are 5, 7, 13 and 29.
-- | What is the largest prime factor of the number 600851475143 ?

import Math.Primality

main :: IO()
main = do
    let answer = last $ primeFactors 600851475143
    print answer
