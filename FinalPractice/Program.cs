using System;
using System.Linq;

namespace ArrayPractice 
{
  class Program 
  {
   static  int sumOfArrays(int[] array) 
    {
      int sum = 0;
      foreach(int i in array) 
      {
        sum += i;
      }
      return sum;
    }
    public static void Main(string[] args) 
    {
      Console.WriteLine("Number of elements to be in an array: ");
      int n = int.Parse(Console.ReadLine());
      int[] array_a = new int[n];

      for (int i = 0; i < n; i++) 
      {
        Console.WriteLine("Enter number: ");
        int num_1 = int.Parse(Console.ReadLine());
        array_a[i] = num_1;
      }
      int result = sumOfArrays(array_a);
      Console.WriteLine("Total sum is: " + result);
    }
  }
}