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
  var solver = new Solver();
  List<decimal> array  = new List<decimal>() { 200, 100, 100, 50, 50, 50, 50 };
  for (int i = 1; i <= 10; i++) array.Add(20);
  for (int i = 1; i <= 20; i++) array.Add(10);
  for (int i = 1; i <= 40; i++) array.Add(5);
  for (int i = 1; i <= 100; i++) array.Add(2);
  for (int i = 1; i <= 200; i++) array.Add(1);
  
  solver.Solve(200, array.ToArray()).Dump();
}

public class Solver {

    private List<List<decimal>> mResults;

    public List<List<decimal>> Solve(decimal goal, decimal[] elements) {

        mResults = new List<List<decimal>>();
        RecursiveSolve(goal, 0.0m, 
            new List<decimal>(), new List<decimal>(elements), 0);
        return mResults; 
    }

    private void RecursiveSolve(decimal goal, decimal currentSum, 
        List<decimal> included, List<decimal> notIncluded, int startIndex) {

        for (int index = startIndex; index < notIncluded.Count; index++) {

            decimal nextValue = notIncluded[index];
            if (currentSum + nextValue == goal) {
                List<decimal> newResult = new List<decimal>(included);
                newResult.Add(nextValue);
                mResults.Add(newResult);
            }
            else if (currentSum + nextValue < goal) {
                List<decimal> nextIncluded = new List<decimal>(included);
                nextIncluded.Add(nextValue);
                List<decimal> nextNotIncluded = new List<decimal>(notIncluded);
                nextNotIncluded.Remove(nextValue);
                RecursiveSolve(goal, currentSum + nextValue,
                    nextIncluded, nextNotIncluded, startIndex++);
            }
        }
    }
}
