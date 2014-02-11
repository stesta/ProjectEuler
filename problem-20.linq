<Query Kind="Expression">
  <Connection>
    <ID>1bc2d5cd-0a7b-4e0f-b329-2f8f878c247f</ID>
    <Persist>true</Persist>
    <Server>srv-hsimdm</Server>
    <NoPluralization>true</NoPluralization>
    <NoCapitalization>true</NoCapitalization>
    <Database>Salesforce_Mirror</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Output>DataGrids</Output>
  <NuGetReference>Dapper</NuGetReference>
  <NuGetReference>DapperExtensions</NuGetReference>
  <NuGetReference>MathNet.Numerics</NuGetReference>
  <Namespace>Dapper</Namespace>
  <Namespace>DapperExtensions</Namespace>
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