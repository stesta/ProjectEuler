-- If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.
-- {20,48,52}, {24,45,51}, {30,40,50}
-- For which value of p ≤ 1000, is the number of solutions maximised?

import Math.Pythagorean (triplesScaled)
import Data.List (maximumBy)
import Data.Ord (comparing)

main :: IO () 
main = do 
    let answer = fst . maximumBy (comparing snd) $ 
                    [x | x <- map (\n -> (n, length . triplesScaled $ n)) [1..999]]
    print answer
