<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

//Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
//
// 1634 = 1^4 + 6^4 + 3^4 + 4^4
// 8208 = 8^4 + 2^4 + 0^4 + 8^4
// 9474 = 9^4 + 4^4 + 7^4 + 4^4
//
//As 1 = 14 is not a sum it is not included.
//
//The sum of these numbers is 1634 + 8208 + 9474 = 19316.
//
//Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.

int power = 5;
int total = 0;

for (int a = 0; a <= 9; a++)
for (int b = 0; b <= 9; b++)
for (int c = 0; c <= 9; c++)
for (int d = 0; d <= 9; d++)
for (int e = 0; e <= 9; e++)
for (int f = 0; f <= 9; f++)
{
  var left =  Math.Pow(a,power) + Math.Pow(b,power) + Math.Pow(c,power) + Math.Pow(d,power) + Math.Pow(e,power) + Math.Pow(f,power);
  var right = a*100000 + b*10000 + c*1000 + d*100 + e*10 + f;
  
  if (left == right && right != 1 && right != 0)
    total += right;
}

total.Dump();

