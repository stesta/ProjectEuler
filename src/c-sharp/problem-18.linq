<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
  int total = 0;
  int inc = 0;
  int currentPos = 0;
  
  foreach (var row in Pyramid)
  {
    total += row[currentPos].Dump();
    currentPos += ComparePath(inc, currentPos);
    inc++;
  }
  
  total.Dump();
}

public List<int[]> Pyramid
{
  get
  {
    return new List<int[]>() {
                                new int[] { 75 },
                              new int[] { 95, 64 },
                            new int[] { 17, 47, 82 },
                          new int[] { 18, 35, 87, 10 },
                        new int[] { 20, 04, 82, 47, 65 },
                      new int[] { 19, 01, 23, 75, 03, 34 },
                    new int[] { 88, 02, 77, 73, 07, 63, 67 },
                  new int[] { 99, 65, 04, 28, 06, 16, 70, 92 },
                new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 },
              new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 },
            new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 },
          new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 5 },
        new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 },
      new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 },
    new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 }
    };
  }
}


public int ComparePath(int startRow, int pos)
{
  int leftPath = 0;
  int rightPath = 0;

  int inc = 0;
  foreach (var row in Pyramid.Skip(startRow))
  {
    if (inc == 0)
    {
      leftPath += row[pos];
      rightPath += row[pos];
    }
    else
    {
      leftPath += row[pos];
      rightPath += row[pos+inc];
    }

    inc++;
  }
  
//  leftPath.Dump();
//  rightPath.Dump();
  
  if (leftPath > rightPath)
    return 0;
  else
    return 1;
}
// Define other methods and classes here