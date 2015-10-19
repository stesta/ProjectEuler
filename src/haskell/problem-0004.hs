-- | A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
-- | Find the largest palindrome made from the product of two 3-digit numbers.

import Math.Integers

main :: IO()
main = do 
    let products = [x * y | x <- [100..999], y <- [100..999]]
        palindromes = filter (\n -> isPalindrome n) products
        answer = maximum palindromes
         
    print answer 