<Query Kind="Program" />

void Main()
{
	//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
	//
	//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
	
	var digits = Enumerable.Range(1,10).Reverse();
	
	int result = 1;
	foreach (var x in digits)
	{
		var y = result*x;
	}
	
}

// Define other methods and classes here
public bool divisibleByCollection(IEnumerable<int> digits, int x)
{
	foreach (var d in digits)
	{
		if (x % d != 0) 
			return false;
	}
		
	return true;
}