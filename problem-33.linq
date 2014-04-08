<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
  // The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
  // We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
  // There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.
  // If the product of these four fractions is given in its lowest common terms, find the value of the denominator.
  
  for(int x = 10; x <= 99; x++)
  for(int y = 10; y <= 99; y++)
  {
    double actual = (double)x/(double)y;
    if (actual >= 1)
      continue;
    
    var xArr = digitArr(x);
    var yArr = digitArr(y);
    
    if (yArr[0] != 0)
    if (xArr[0] == yArr[1] && xArr[1] != yArr[0] && actual == ((double)xArr[1]/(double)yArr[0]))
    {
      string.Format("{0}/{1} == {2} \n",x,y, actual).Dump();
    }
    
    if (yArr[1] != 0)
    if (xArr[1] == yArr[0] && xArr[0] != yArr[1] && actual == ((double)xArr[0]/(double)yArr[1]))
    {
      string.Format("{0}/{1} == {2} \n",x,y, actual).Dump();
    }
  }
}

// Define other methods and classes here
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
