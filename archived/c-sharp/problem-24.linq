<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>MathNet.Numerics</NuGetReference>
  <Namespace>MathNet.Numerics</Namespace>
</Query>

//A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. 
//If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. 
//The lexicographic permutations of 0, 1 and 2 are:
//
//  012   021   102   120   201   210
//
//What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
  
void Main()
{
  Recursion r = new Recursion();
  r.InputSet = r.MakeCharArray("0123456789");
  r.CalcPermutation(0);
  
  r.permutations.OrderBy(p => p)
                .Skip(999999)
                .Take(1)
                .Dump();
}

/// <summary>
/// Algorithm Source: A. Bogomolny, Counting And Listing 
/// All Permutations from Interactive Mathematics Miscellany and Puzzles
/// http://www.cut-the-knot.org/do_you_know/AllPerm.shtml, Accessed 11 June 2009
/// </summary>
class Recursion
{
    private int elementLevel = -1;
    private int numberOfElements;
    private int[] permutationValue = new int[0];
    public List<long> permutations = new List<long>();

    private char[] inputSet;
    public char[] InputSet
    {
        get { return inputSet; }
        set { inputSet = value; }
    }

    private int permutationCount = 0;
    public int PermutationCount
    {
        get { return permutationCount; }
        set { permutationCount = value; }
    }

    public char[] MakeCharArray(string InputString)
    {
        char[] charString = InputString.ToCharArray();
        Array.Resize(ref permutationValue, charString.Length);
        numberOfElements = charString.Length;
        return charString;
    }

    public void CalcPermutation(int k)
    {
        elementLevel++;
        permutationValue.SetValue(elementLevel, k);

        if (elementLevel == numberOfElements)
        {
            OutputPermutation(permutationValue);
        }
        else
        {
            for (int i = 0; i < numberOfElements; i++)
            {
                if (permutationValue[i] == 0)
                {
                    CalcPermutation(i);
                }
            }
        }
        elementLevel--;
        permutationValue.SetValue(0, k);
    }

    private void OutputPermutation(int[] value)
    {
        string val = "";
        foreach (int i in value)
        {
            val += inputSet.GetValue(i - 1).ToString();
        }
        
        long l = 0;
        if (long.TryParse(val, out l))
        {
          permutations.Add(l);
        }
        
        PermutationCount++;
    }
}
