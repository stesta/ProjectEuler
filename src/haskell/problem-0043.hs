-- The number, 1406357289, is a 0 to 9 pandigital number because it is made up of each of the digits 0 to 9 in some order, but it also has a rather interesting sub-string divisibility property.
-- 
-- Let d1 be the 1st digit, d2 be the 2nd digit, and so on. In this way, we note the following:
-- 
-- d2d3d4=406 is divisible by 2
-- d3d4d5=063 is divisible by 3
-- d4d5d6=635 is divisible by 5
-- d5d6d7=357 is divisible by 7
-- d6d7d8=572 is divisible by 11
-- d7d8d9=728 is divisible by 13
-- d8d9d10=289 is divisible by 17
-- Find the sum of all 0 to 9 pandigital numbers with this property.

import Data.List

pandigitals :: [String]
pandigitals = permutations "0123456789"

checklist :: String -> [Int]
checklist s = [x | p <- [1..7], let substr = (s!!p):(s!!(p+1)):(s!!(p+2)):[], let x = read substr]

interestingProperty :: String -> Bool 
interestingProperty s
    | cl1 && cl2 && cl3 && cl4 && cl5 && cl6 && cl7 = True
    | otherwise = False
    where cl = checklist s
          cl1 = mod (cl!!0) 2  == 0
          cl2 = mod (cl!!1) 3  == 0
          cl3 = mod (cl!!2) 5  == 0
          cl4 = mod (cl!!3) 7  == 0
          cl5 = mod (cl!!4) 11 == 0
          cl6 = mod (cl!!5) 13 == 0
          cl7 = mod (cl!!6) 17 == 0


main :: IO ()
main = do 
    let answer = sum . map read . filter interestingProperty $ pandigitals
    print answer
