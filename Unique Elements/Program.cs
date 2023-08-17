using System;
using System.Linq;

namespace uniqueValues 
{
  class Program
  {
    static int[] originalArray(int[] array) 
    {
      HashSet<int> unique_values = new HashSet<int>(array);
      return unique_values.ToArray();
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Enter the number of elements to be in a array");
      int n = int.Parse(Console.ReadLine());
      
      int[] array_a = new int[n];

      for (int i = 0; i < n; i++) 
      {
        Console.Write("Enter number: ");
        array_a[i] = int.Parse(Console.ReadLine());
      }

      Console.Write("unique values are : ");
      
      int[] result = originalArray(array_a);
      foreach (int item in result) 
      {
        Console.Write(item + " ");
      }
      
    }
  }
}

