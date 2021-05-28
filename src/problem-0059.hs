import System.IO ()
import Data.Bits (xor)
import Data.List (isInfixOf)

main :: IO ()
main = do
    cipher <- toByteArray <$> readFile "data/p059_cipher.txt"
    let decryptions = [map toEnum $ zipWith xor cipher k | k <- keys] :: [[Char]]
        winner = head $ filter (isInfixOf "Euler") decryptions -- originally used "the" and visually parsed through results
    print $ sum . map fromEnum $ winner

keys :: [[Int]]
keys = [cycle . map fromEnum $ [x,y,z] | x <- ['a'..'z'], y <- ['a'..'z'], z <- ['a'..'z']]

splitBy :: Char -> String -> [String]
splitBy _ [] = []
splitBy c s  =
  let
    i = (length . takeWhile (/= c)) s
    (as, bs) = splitAt i s
  in as : splitBy c (if null bs then [] else tail bs)

toByteArray :: String -> [Int]
toByteArray xs = map read arr
    where arr = splitBy ',' xs