module Math.Integers where
import Numeric (showIntAtBase)
import Data.Char (intToDigit)

toIntegerArray :: Integral a => a -> [a]
toIntegerArray n
    | n == 0    = []
    | otherwise = toIntegerArray (n `div` 10) ++ [n `mod` 10]

fromIntegerArray :: [Integer] -> Integer
fromIntegerArray = foldl addDigit 0
   where addDigit num d = 10*num + d

isPalindrome :: Show a => a -> Bool
isPalindrome n = x == reverse x
    where x = show n

toBinary :: Integer -> String
toBinary = flip (showIntAtBase 2 intToDigit) ""
