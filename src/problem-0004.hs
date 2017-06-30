-- A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
-- Find the largest palindrome made from the product of two 3-digit numbers.

import Math.Integers

problem_0004 :: Integer
problem_0004 = maximum [x | y <- [100..999], z <- [100..999], let x = y*z, isPalindrome x]
