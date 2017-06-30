<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

  //In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:
  //
  //1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
  //
  //It is possible to make £2 in the following way:
  //
  //1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
  //
  //How many different ways can £2 be made using any number of coins?
  
void Main()
{
  int[] coins = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };
  var result = coins.CombinationsToTarget(200);
  
  result.Dump();
}

public static class SetTheoryHelpers
{
  public static int CombinationsToTarget(this int[] set, int target)
  {
    int[] combinations = new int[target+1];
    combinations[0] = 1;
    
    // loop through and continually add combinations to individual array values
    foreach (var item in set)
      foreach(var i in Enumerable.Range(item, (target+1)-item))
        combinations[i] += combinations[i - item];
        
    return combinations[target];
  }
}


