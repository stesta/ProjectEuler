module Math.Integers where

toIntegerArray :: Integral n => n -> [n]
toIntegerArray n  
    | n == 0    = []
    | otherwise = toIntegerArray (n `div` 10) ++ [n `mod` 10] 
    
isPalindrome :: Integral n => n -> Bool
isPalindrome n = toIntegerArray n == reverse (toIntegerArray n)  