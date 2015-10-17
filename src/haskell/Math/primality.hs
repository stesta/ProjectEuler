module Math.Primality where

isPrime :: Integral n => n -> Bool 
isPrime n = n > 1 &&
              foldr (\p r -> p*p > n || ((n `rem` p) /= 0 && r))
                True (2:[3,5..])
                    
primeFactors :: Integral n => n -> [n]
primeFactors n | n > 1 = go n (2:[3,5..])   -- or go n (2:[3,5..])
   where                               -- for one-off invocation
     go n ps@(p:t)
        | p*p > n    = [n]
        | r == 0     =  p : go q ps
        | otherwise  =      go n t
                where
                  (q,r) = quotRem n p