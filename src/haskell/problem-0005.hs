-- | 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
-- | What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

main :: IO()
main = do
   -- | prime factorization
    let answer = foldl lcm 1 [1..20] :: Int
    print answer
