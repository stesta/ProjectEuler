module Math.Combinatorics
    ( circularPermutations
    , permutations
    , isPermutation
    ) where
import Data.List (tails, permutations)

circularPermutations :: Integer -> [Integer]
circularPermutations n = take l $ map (read . take l) $ tails $ take (2*l -1) $ cycle s
    where
        s = show n
        l = length s

perms :: Integer -> [Integer]
perms = map read . permutations . show 

isPermutation :: Integer -> Integer -> Bool
isPermutation x y = (show y) `elem` (permutations . show $ x)