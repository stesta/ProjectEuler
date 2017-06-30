module Math.Series
    ( fibonacci
    ) where

fibonacci :: [Integer]
fibonacci = 1 : 2 : zipWith (+) fibonacci (tail fibonacci)
