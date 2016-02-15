import Math.Primality

main :: IO()
main = do
    let factors = primeFactors 40
    print factors
