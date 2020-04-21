<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

// 145 is a curious number, as 1!+4!+5! = 1 + 24 + 120 = 145.
// Find the sum of all numbers which are equal to the sum of the factorial of their digits.
// Note: as 1! = 1 and 2! = 2 are not sums they are not included.


void Main()
{	
	Enumerable.Range(3, 100000)
		.Where(n => n.DigitFactorialsSumToNumber())
		.Sum()
		.Dump();
}


public static class ProblemExtensions
{
	public static bool DigitFactorialsSumToNumber(this int n)
	{
		return n == n.ParseDigits().Sum(digit => digit.Factorial());
	}
}


public static class MathExtensions
{
	public static Dictionary<int, int> MemoizedFactorials = new Dictionary<int, int>()
	{
		{ 0, 1}, 
		{ 1, 1}, 	
		{ 2, 2}, 
		{ 3, 6}, 
		{ 4, 24}, 
		{ 5, 120}, 
		{ 6, 720}, 
		{ 7, 5040}, 
		{ 8, 40320}, 
		{ 9, 362880}, 
	};

	public static int Factorial(this int n)
	{
		if (n >= 0 && n <= 9) 
		{
			return MemoizedFactorials[n];
		}
		
		return Enumerable.Range(1,n)
			.Aggregate ((p, a) => p*a);
	}
	
	public static IEnumerable<int> ParseDigits(this int n)
	{
		while (n > 0)
		{
			yield return n % 10;
			n = n / 10;
		}
	}
}