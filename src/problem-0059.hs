

import System.IO
import Data.Bits (xor)

main :: IO ()
main = do
    cipher <- toByteArray <$> readFile "data/p059_cipher.txt"
    let keys = [[x,y,z] | x <- ['a'..'z'], y <- ['a'..'z'], z <- ['a'..'z']]
        decryptions = map (xor cipher) keys
    print keys

splitBy :: Char -> String -> [String]
splitBy _ [] = []
splitBy c s  =
  let
    i = (length . takeWhile (/= c)) s
    (as, bs) = splitAt i s
  in as : splitBy c (if bs == [] then [] else tail bs)

toByteArray :: String -> [Int]
toByteArray xs = map read arr
    where arr = splitBy ',' xs