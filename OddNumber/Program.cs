using System;
using System.Linq;

namespace OddNumber
{
  class Program 
  {
    static int[] OddNumber(int[] array) 
    {
      int count = 0;
      foreach (int num in array) 
      {
        if (num % 2 != 0) 
        {
          count++;
        }
      }

      int[] oddArray = new int[count];  
      int index = 0;

      foreach (int i in array) 
      {
        if (i % 2 != 0) 
        {
          oddArray[index] = i;
          index++;
        }
      }
      return oddArray;
    }

    static void Main(string[] args) 
    {
      Console.WriteLine("Enter number of elements to be in a array");
      int n = int.Parse(Console.ReadLine());
      int[] array_a = new int[n];

      for (int i = 0; i < array_a.Length; i++) 
      {
        Console.Write("Give Number: ");
        array_a[i] = int.Parse(Console.ReadLine());
      }
      int[] result = OddNumber(array_a);
      Console.Write("Odd numbers are: ");
      foreach (int item in result) 
      {
        Console.Write(item + " ");
      }

    }
  }
}
