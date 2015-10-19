module Math.Integers where

toIntegerArray :: Int -> [Int]
toIntegerArray n  
    | n == 0    = []
    | otherwise = toIntegerArray (n `div` 10) ++ [n `mod` 10] 
    
fromIntegerArray :: [Int] -> Int
fromIntegerArray = foldl addDigit 0
   where addDigit num d = 10*num + d
    
isPalindrome :: Int -> Bool
isPalindrome n = toIntegerArray n == reverse (toIntegerArray n)  