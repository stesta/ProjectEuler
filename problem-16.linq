<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>MathNet.Numerics</NuGetReference>
  <Namespace>MathNet.Numerics</Namespace>
</Query>

void Main()
{
  int squares = 20;

  var answer = SpecialFunctions.Factorial(2*squares) / (SpecialFunctions.Factorial(squares) * SpecialFunctions.Factorial(squares));
  answer.Dump();
}

// Define other methods and classes here
