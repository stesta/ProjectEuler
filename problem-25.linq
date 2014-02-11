<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>Dapper</NuGetReference>
  <NuGetReference>DapperExtensions</NuGetReference>
  <NuGetReference>MathNet.Numerics</NuGetReference>
  <Namespace>Dapper</Namespace>
  <Namespace>DapperExtensions</Namespace>
</Query>

  //The Fibonacci sequence is defined by the recurrence relation:
  //
  //Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
  //Hence the first 12 terms will be:
  //
  //F1 = 1
  //F2 = 1
  //F3 = 2
  //F4 = 3
  //F5 = 5
  //F6 = 8
  //F7 = 13
  //F8 = 21
  //F9 = 34
  //F10 = 55
  //F11 = 89
  //F12 = 144
  //The 12th term, F12, is the first term to contain three digits.
  //
  //What is the first term in the Fibonacci sequence to contain 1000 digits?

void Main()
{     
  FibonacciSeries(10000).FirstOrDefault(x => x.Item2.ToString().ToCharArray().Length == 1000).Dump();
}

private static IEnumerable<Tuple<long, System.Numerics.BigInteger>> FibonacciSeries(long n)
{
    System.Numerics.BigInteger previousValue = 1;
    System.Numerics.BigInteger nextValue = 0;
    System.Numerics.BigInteger secondPreviousValue = 0;
    yield return Tuple.Create(1L, new System.Numerics.BigInteger(1));
    
    for (long i = 2; i <= n; i++)
    {
        nextValue = previousValue + secondPreviousValue;
        secondPreviousValue = previousValue;
        previousValue = nextValue;
        yield return Tuple.Create(i, nextValue);
    }
}

