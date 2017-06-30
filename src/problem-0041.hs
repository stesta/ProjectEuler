-- We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.
-- What is the largest n-digit pandigital prime that exists?

import Math.Primality (isPrime)
import Data.Char (intToDigit)
import Data.List (permutations)


problem_0041 :: Integer
problem_0041 = maximum . filter isPrime $ pandigitals


-- generate a list of pandigitals by permuting "123", "1234" ... "123456789"
-- this is a better optimization than testing for pandigital across an array of integers
pandigitals :: (Integral a, Read a) => [a]
pandigitals =  [n | d <- [3..9], p <- permutations ['1'..intToDigit d], let n = read p]
