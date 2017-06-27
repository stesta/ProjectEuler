module Math.Combinatorics where
import Data.List (tails)

circularPermutations :: Integer -> [Integer]
circularPermutations n = take l $ map (read . take l) $ tails $ take (2*l -1) $ cycle s
    where
        s = show n
        l = length s
