<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
// The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
// Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
// HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.

void Main()
{
  List<Tuple<int,int,int>> pandigitals = new List<Tuple<int, int, int>>();

  // Brute force; 
  // original bounds x=9999; y=9999; adjusted bounds post answer for performance
  for (int x = 1; x <= 500; x++)
  for (int y = 1; y <= 2000; y++)
  {
    if (IsPandigital(x,y))
      pandigitals.Add(Tuple.Create(x,y,x*y));
  }
  
  pandigitals.Dump()
             .Select(n => n.Item3)
             .Distinct()
             .Sum()
             .Dump();
}

bool IsPandigital(int x, int y)
{
  var all = digitArr(x).Concat(digitArr(y)).Concat(digitArr(x*y));
  if (all.Count() != 9)
    return false;
  
  for(int i = 1; i <= 9; i++)
    if (!all.Contains(i))
      return false;
  
  return true;
}

public static int[] digitArr(int n)
{
    if (n == 0) return new int[1] { 0 };

    var digits = new List<int>();

    for (; n != 0; n /= 10)
        digits.Add(n % 10);

    var arr = digits.ToArray();
    Array.Reverse(arr);
    return arr;
}