<Query Kind="Program">
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
  <Namespace>Dapper</Namespace>
  <Namespace>DapperExtensions</Namespace>
</Query>

// Same as problem 18, but designed so that you couldn't have used a brute force method

void Main()
{
  int[] prevRow = null;
  InitializePyramid();
  _pyramid.Reverse();
  
  // traverse pyramid backwards
  foreach (var row in _pyramid)
  {
    if (prevRow == null)
    {
      prevRow = row;
      continue;
    }
  
    // get the highest adjacent value from the previous row and add it to the current row
    for (int i = 0; i < row.Length; i++)
      row[i] += Math.Max(prevRow[i], prevRow[i+1]);

    prevRow = row;
  }
  
  prevRow.Dump();
}

private List<int[]> _pyramid = null;
private void InitializePyramid() 
{
  if (_pyramid == null)
  {
    _pyramid = new List<int[]>();
    
    using (System.IO.StreamReader sr = new StreamReader("c:/code/scripts/linq/projecteuler/problem67.txt"))
    {
      while(sr.Peek() >= 0)
      {
          string line = sr.ReadLine();
          _pyramid.Add(line.Split(' ').Select(x => int.Parse(x)).ToArray());
      }
    }
  }
}