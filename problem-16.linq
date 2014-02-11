<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>Dapper</NuGetReference>
  <NuGetReference>DapperExtensions</NuGetReference>
  <NuGetReference>MathNet.Numerics</NuGetReference>
  <Namespace>Dapper</Namespace>
  <Namespace>DapperExtensions</Namespace>
  <Namespace>MathNet.Numerics</Namespace>
</Query>

void Main()
{
  int squares = 20;

  var answer = SpecialFunctions.Factorial(2*squares) / (SpecialFunctions.Factorial(squares) * SpecialFunctions.Factorial(squares));
  answer.Dump();
}

// Define other methods and classes here
