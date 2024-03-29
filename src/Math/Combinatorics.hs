module Math.Combinatorics
    ( circularPermutations
    , permutations
    , isPermutation
    , ncr
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


ncr :: (Fractional a, Enum a) => a -> a -> a
ncr n r = fac n / (fac r * fac (n-r))
    where fac n = product [1..n]