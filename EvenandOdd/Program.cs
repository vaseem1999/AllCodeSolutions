using System;
using System.Linq;

namespace evenOdd 
{
  class Program 
  {
    static void bothEvenOdd(int[] array) 
    {
      
      foreach (int i in array) 
      {
        if (i % 2 == 0)
        {
          Console.WriteLine("Even number: " + i);
        }
        else 
        {
          Console.WriteLine("Odd Number: " + i);
        }
      }

     
      
    }
    static void Main(string[] args) 
    {
      Console.WriteLine("Enter the number of elements to be in a array");
      int n = int.Parse(Console.ReadLine());
      int[] array_a = new int[n];
      for(int i = 0; i < array_a.Length; i++) 
      {
        Console.WriteLine("Enter the number here: ");
        array_a[i] = int.Parse(Console.ReadLine());
      }
      bothEvenOdd(array_a);
    }
  }
}
