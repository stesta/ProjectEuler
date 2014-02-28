<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
  int counter = 0;
  int target = 10001;
  
  int x = 2;
  while (counter != target)
  {
    if (IsPrime(x))
      counter++;
    
    x++;
  }
  
  (x-1).Dump();
}

public bool IsPrime(int x)
{
	if ((x & 1) == 0)
	{
	    if (x == 2) // 2 is the only even number that is prime
		    return true;
		  else
        return false;
	}
	
	for (int i = 3; (i * i) <= x; i += 2)
	{
	    if ((x % i) == 0)
		    return false;
	}
  
	return x != 1;
}