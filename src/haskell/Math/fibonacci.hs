module Math.Fibonacci where

fibonacci = 1 : 2 : zipWith (+) fibonacci (tail fibonacci)