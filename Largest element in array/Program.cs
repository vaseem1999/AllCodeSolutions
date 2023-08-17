using System;
using System.Linq;

namespace LargestELement 
{
  class Program 
  {
    static int MaxElement(int[] array) 
    {
      return array.Max();
    }
    static void Main(string[] args) 
    {
      Console.WriteLine("Number of elements to be in a array: ");
      int n = int.Parse(Console.ReadLine()); ;
      int[] array_a = new int[n];
      for (int i = 0; i < n; i++) 
      {
        Console.Write("Enter the number: ");
        array_a[i] = int.Parse(Console.ReadLine());
      }
      int result = MaxElement(array_a);
      Console.WriteLine("Largest Element is: " + result);
    }
  }
}