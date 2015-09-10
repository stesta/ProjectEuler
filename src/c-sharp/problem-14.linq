<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>MathNet.Numerics</NuGetReference>
</Query>

void Main()
{

//  Enumerable.Range(1,250000)
//            .Select(x => CollatzSequence(x))
//            .OrderByDescending(x => x.Count())
//            .Dump();
//            
//  Enumerable.Range(250001,250000)
//            .Select(x => CollatzSequence(x))
//            .OrderByDescending(x => x.Count())
//            .Dump();
            
  Enumerable.Range(500001,250000)
            .Select(x => CollatzSequence(x))
            .OrderByDescending(x => x.Count())
            .Dump();
            
  Enumerable.Range(750001,249998)
            .Select(x => CollatzSequence(x))
            .OrderByDescending(x => x.Count())
            .Dump();
}

public static IEnumerable<long> CollatzSequence(long x)
{
  var results = new List<long>();
  results.Add(x);

  while(x != 1)
  {
    if (x % 2 == 0)
      x = x/2;
    else
      x = (3*x)+1;
    
    results.Add(x);
  }
  
  return results;
}

// Define other methods and classes here