<Query Kind="Program">
  <Output>DataGrids</Output>
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
