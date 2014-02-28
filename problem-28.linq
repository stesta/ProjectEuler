<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

//Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
//
// 21 22 23 24 25
// 20  7  8  9 10
// 19  6  1  2 11
// 18  5  4  3 12
// 17 16 15 14 13
//
//It can be verified that the sum of the numbers on the diagonals is 101.
//
//What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?


void Main()
{
  int total = 0;  
  int skipLength = 1;
  int skipCounter = 0;
  
  int arraySize = 1001*1001;
  for (int i = 1; i <= arraySize; i++)
  {
    total += i;
    i += skipLength;

    skipCounter++;
    if (skipCounter % 4 == 0)
      skipLength += 2;
  }
 
  total.Dump();
}

// Define other methods and classes here
