using System;
using System.Linq;

namespace reverseAray 
{
  class Program 
  {
    static int[] reverseArray(int[] array)
    {
      int length = array.Length;
      int[] rev_array = new int[length];
      for(int i = 0 ; i < length; i++ ) 
      {
        rev_array[i] = array[length - i -1];
      }
      return rev_array;
    }
    
    static void Main(string[] args) 
    {
      Console.WriteLine("Number of elements to be in a array: ");
      int n = int.Parse(Console.ReadLine());
      int[] array_a = new int[n];

      for (int i = 0; i < n; i++) 
      {
        Console.Write("Enter Number: ");
        array_a[i] = int.Parse(Console.ReadLine());
      }
      int[] result = reverseArray(array_a);
      foreach (int i in result) 
      {
        Console.WriteLine(i);
      }

    }
  }
}