using System;
using System.Linq;

namespace arrayAverage
{
  class Program 
  {
    static int avrerageArray(int[] array, int m) 
    {
      int avverage_value = 0;
      foreach (int i in array) 
      {
        avverage_value += i;
      }
      return avverage_value/m;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the number of elements in an array:");
      int n = int.Parse(Console.ReadLine());
      int[] array_a = new int[n];

      for (int i = 0; i < n; i++) 
      {
        Console.WriteLine("Enter the values: ");
        array_a[i] = int.Parse(Console.ReadLine());
      }
      int result = avrerageArray(array_a, n);
      Console.WriteLine("The average of the give array values is: " + result);
    }
  }
}