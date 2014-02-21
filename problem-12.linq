<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>Dapper</NuGetReference>
  <NuGetReference>DapperExtensions</NuGetReference>
  <NuGetReference>MathNet.Numerics</NuGetReference>
  <Namespace>Dapper</Namespace>
  <Namespace>DapperExtensions</Namespace>
</Query>

//The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
//
//1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
//
//Let us list the factors of the first seven triangle numbers:
//
// 1: 1
// 3: 1,3
// 6: 1,2,3,6
//10: 1,2,5,10
//15: 1,3,5,15
//21: 1,3,7,21
//28: 1,2,4,7,14,28
//
//We can see that 28 is the first triangle number to have over five divisors.
//
//What is the value of the first triangle number to have over five hundred divisors?


void Main()
{
  // first number output is the winner
  Enumerable.Range(1,50000)
            .ToList()
            .ForEach(i => {
              var trinum = CalculateTriangleNumber(i);
              if (Divisors(trinum).Count() > 500)
                trinum.Dump();
            });
}

public long CalculateTriangleNumber(int row)
{
  long value = 0;
  for (int i = row; i > 0; i--)
    value += i;
    
  return value;
}

public IEnumerable<int> Divisors(long x, bool includeSelf = true)
{
  double sqrt = Math.Sqrt(x);
  List<int> belowSqrt = new List<int>();

  // get all divisors below the square root
  for (int i = 1; i <= sqrt; i++)
  {
    if (x % i == 0)
    {
      if (i != sqrt)
        belowSqrt.Add(i);
        
      yield return i;
    }
  }
    
  // return the top pairing of the numbers below the square root
  belowSqrt.Reverse();
  foreach (var i in belowSqrt)
  {
    int topPair = (int)(x / i);
    if (!includeSelf && topPair == x)
      continue;
      
    yield return topPair; 
  }
}