-- | The decimal number, 585 = 1001001001 (binary), is palindromic in both bases.
-- | Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
-- | (Please note that the palindromic number, in either base, may not include leading zeros.)

import Math.Integers (isPalindrome, toBinary)

main :: IO()
main = do
    -- | note the 'odd' constraint is because a binary palindrome can never be an even number because they wouldn't start and end with a '1'
    let answer = sum [x | x <- [1..1000000], odd x && isPalindrome x && isPalindrome (toBinary x)]
    print answer
