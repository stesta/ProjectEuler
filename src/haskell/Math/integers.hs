module Math.Integers where
import Numeric (showIntAtBase)
import Data.Char (intToDigit)
import Data.List (sort)

toIntegerArray :: Integral a => a -> [a]
toIntegerArray n
    | n == 0    = []
    | otherwise = toIntegerArray (n `div` 10) ++ [n `mod` 10]

fromIntegerArray :: [Integer] -> Integer
fromIntegerArray = read . concatMap show

numDigits :: Integer -> Int 
numDigits = length . show

isPalindrome :: Show a => a -> Bool
isPalindrome n = x == reverse x
    where x = show n

toBinary :: Integer -> String
toBinary = flip (showIntAtBase 2 intToDigit) "" 

isPandigital :: Integer -> Bool
isPandigital = (['1'..'9'] ==) . sort . show
