import System.Process


main :: IO()
main = problemSelection 1


problemSelection :: Int -> IO ()
problemSelection n
    | n == 1    = print "123"
    | otherwise = print "invalid selection"
