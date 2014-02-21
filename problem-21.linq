<Query Kind="Program">
  <Connection>
    <ID>5b90eadf-080d-45ad-a510-72c47516cc62</ID>
    <Persist>true</Persist>
    <Server>srv-tdb1</Server>
    <NoPluralization>true</NoPluralization>
    <NoCapitalization>true</NoCapitalization>
    <Database>Community_Custom</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Output>DataGrids</Output>
  <NuGetReference>Dapper</NuGetReference>
  <NuGetReference>DapperExtensions</NuGetReference>
  <Namespace>Dapper</Namespace>
  <Namespace>DapperExtensions</Namespace>
</Query>

void Main()
{
  //Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
  //If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
  //
  //For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
  //
  //Evaluate the sum of all the amicable numbers under 10000.
  
  var sums = Enumerable.Range(0,10000)
                       .Select(x => Tuple.Create(x, Divisors(x, false).Sum()))
                       .ToList();
                        
  var matches = sums.Where(x => x.Item2 < 10000 // exclude numbers out of range
                        && x.Item1 != x.Item2   // exclude numbers where d(n) = n
                        && x.Item1 == sums[x.Item2].Item2 // d(b) == a
                        && sums[x.Item2].Item1 == x.Item2) // d(a) == b
                    .Dump()
                    .Sum(x => x.Item1)
                    .Dump();
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