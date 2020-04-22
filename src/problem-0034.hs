import Data.Char

main :: IO ()
main = print $ 
    sum [ x | x <- [3..100000], x == facsum x ]
        where facsum = sum . map (product . enumFromTo 1 . digitToInt) . show
    