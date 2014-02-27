<Query Kind="Expression">
  <Output>DataGrids</Output>
  <NuGetReference>MathNet.Numerics</NuGetReference>
</Query>

//n! means n × (n − 1) × ... × 3 × 2 × 1
//
//For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
//and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
//
//Find the sum of the digits in the number 100!

Enumerable.Range(1,100)
          .Select(x => new System.Numerics.BigInteger(x))
          .Aggregate((x, y) => System.Numerics.BigInteger.Multiply(x,y)).Dump()
          .ToString()
          .ToCharArray()
          .Select(ch => int.Parse(ch.ToString()))
          .Aggregate((x,y) => x += y)