-- Pentagonal numbers are generated by the formula, Pn=n(3n−1)/2. The first ten pentagonal numbers are:
-- 1, 5, 12, 22, 35, 51, 70, 92, 117, 145, ...
-- It can be seen that P4 + P7 = 22 + 70 = 92 = P8. However, their difference, 70 − 22 = 48, is not pentagonal.
-- Find the pair of pentagonal numbers, Pj and Pk, for which their sum and difference are pentagonal and D = |Pk − Pj| is minimised; what is the value of D

import Data.Set

pentagonalSeries :: [Integer]
pentagonalSeries = [(n*(3*n-1)) `div` 2 | n <- [1..]]


isPentagonal :: Integer -> Bool
isPentagonal n = n `elem` ps
    where ps = takeWhile (<=n) pentagonalSeries


evaluatePair :: Integer -> Integer -> Bool
evaluatePair pj pk = isPentagonal (pj+pk) && isPentagonal (pk-pj)


-- there must be a smarter approach... the correct answer takes too long to generate
main :: IO ()
main = do
    let answer = head [b-a | b <- pentagonalSeries, a <- takeWhile (<b) pentagonalSeries, evaluatePair a b] 
    print answer