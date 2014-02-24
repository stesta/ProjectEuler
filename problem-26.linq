<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>Dapper</NuGetReference>
  <NuGetReference>DapperExtensions</NuGetReference>
  <NuGetReference>MathNet.Numerics</NuGetReference>
  <Namespace>Dapper</Namespace>
  <Namespace>DapperExtensions</Namespace>
</Query>

//Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.

// algorithm derived from the following research; boils down to multiplicative order
// http://mathworld.wolfram.com/DecimalExpansion.html
// http://mathworld.wolfram.com/MultiplicativeOrder.html

void Main()
{
  var nums = Enumerable.Range(2, 998)
    .Select(n => new { n = n, cycle = UnitFractionCycleLength(n) })
    .OrderByDescending(i => i.cycle)
    //.FirstOrDefault()
    .Dump();
}

// calculate cycle for 1/n
int UnitFractionCycleLength(int n)
{
    int remainder = 1;
    int position = 0;
    List<int> mods = new List<int>();
    
    while(position < n && remainder != 0)
    {
       remainder *= 10;
       remainder %= n;
       position++;
       
       if (mods.Contains(remainder))
        return position - (mods.IndexOf(remainder) +1);
       
       mods.Add(remainder);
    }
    
    return 0;
}
// Define other methods and classes here