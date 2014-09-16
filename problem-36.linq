<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

//The decimal number, 585 = 1001001001 (binary), is palindromic in both bases.
//Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
//(Please note that the palindromic number, in either base, may not include leading zeros.)

void Main()
{
	Enumerable.Range(1, 1000000)
			  .ToList();	
}


