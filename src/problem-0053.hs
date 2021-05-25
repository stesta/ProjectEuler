import Math.Combinatorics (ncr)

main :: IO ()
main = print $
    length [(n,r) | n <- [1..100], r <- [1..n-1], ncr n r > 1000000]

