<Query Kind="Program">
  <Output>DataGrids</Output>
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
    
    using (System.IO.StreamReader sr = new StreamReader("/data/problem67.txt"))
    {
      while(sr.Peek() >= 0)
      {
          string line = sr.ReadLine();
          _pyramid.Add(line.Split(' ').Select(x => int.Parse(x)).ToArray());
      }
    }
  }
}