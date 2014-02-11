<Query Kind="Program">
  <Connection>
    <ID>5b90eadf-080d-45ad-a510-72c47516cc62</ID>
    <Persist>true</Persist>
    <Server>srv-tdb1</Server>
    <NoPluralization>true</NoPluralization>
    <NoCapitalization>true</NoCapitalization>
    <Database>Community_Custom</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Output>DataGrids</Output>
  <NuGetReference>Dapper</NuGetReference>
  <NuGetReference>DapperExtensions</NuGetReference>
  <Namespace>Dapper</Namespace>
  <Namespace>DapperExtensions</Namespace>
</Query>

void Main()
{
  int counter = 0;

  for(int year = 1901; year <= 2000; year++)
  for(int month = 1; month <= 12; month++)
  {
    var firstOfMonth = new DateTime(year, month, 1);
    if (firstOfMonth.DayOfWeek == DayOfWeek.Sunday)
      counter++;
  }
  
  counter.Dump();
}

// Define other methods and classes here
