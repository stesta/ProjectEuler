<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>Dapper</NuGetReference>
  <NuGetReference>DapperExtensions</NuGetReference>
  <Namespace>Dapper</Namespace>
  <Namespace>DapperExtensions</Namespace>
</Query>

// Considering quadratics of the form:
// n² + an + b, where |a| < 1000 and |b| < 1000
// Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n = 0.

void Main()
{
  int resultA = 0;
  int resultB = 0;
  int highestPrimeCount = 0;
  
  for (int a = -999; a <= 999; a++)
  for (int b = -999; b <= 999; b++)
  {
    int n = 0;
    while(IsPrime((int)(Math.Pow(n,2) + (a*n) + b)))
    {
      n++;
    }
    
    if (n > highestPrimeCount)
    {
      highestPrimeCount = n;
      resultA = a;
      resultB = b;
    }
  }
  
  ("a: " + resultA + "\nb: " + resultB + "\n#: " + highestPrimeCount).Dump();
  ("a*b: " + resultA*resultB).Dump();
}

public bool IsPrime(int x)
{
  if (x < 0)
    return false;

	if ((x & 1) == 0)
	{
	    if (x == 2) // 2 is the only even number that is prime
		    return true;
		  else
        return false;
	}
	
	for (int i = 3; (i * i) <= x; i += 2)
	{
	    if ((x % i) == 0)
		    return false;
	}
  
	return x != 1;
}