<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

//145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
//Find the sum of all numbers which are equal to the sum of the factorial of their digits.
//Note: as 1! = 1 and 2! = 2 are not sums they are not included.

void Main()
{
	Enumerable.Range(10, int.MaxValue-10)
			  .Where(n => digitArr(n).Sum(c => digitValues[c]) == n)
			  .Sum()
			  .Dump();
}

public static Dictionary<int, int> digitValues = new Dictionary<int, int>()
{
	{ 0, 0 },
	{ 1, 1 },
	{ 2, 2 },
	{ 3, 6 },
	{ 4, 24 },
	{ 5, 120 },
	{ 6, 720 },
	{ 7, 5040 },
	{ 8, 40320 },
	{ 9, 362880 }
};

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