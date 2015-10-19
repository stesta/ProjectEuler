module Math.Combinatorics where
import Data.List (tails)

permutations :: Integer -> [Integer]
permutations n = take l $ map (read . take l) $ tails $ take (2*l -1) $ cycle s
    where
        s = show n
        l = length s