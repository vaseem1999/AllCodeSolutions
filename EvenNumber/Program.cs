using System;
using System.Linq;

namespace evenNumber 
{
  class Program 
  { 
    static int[] evenNumberArray(int[] array) 
    {
      int countEvenOnly = 0;
      foreach (int item in array) 
      {
        if (item % 2 == 0) 
        {
          countEvenOnly++;
        }
      }

      int[] evenArray = new int[countEvenOnly];
      int index = 0 ;
      foreach (int item in array) 
      {
        if (item % 2 == 0) 
        {
          evenArray[index] = item;
          index++;
        }
      }
      return evenArray;

    }
    static void Main(string[] args) 
    {
      Console.WriteLine("Enter the numbe of elements to be in a array: ");
      int n = int.Parse(Console.ReadLine());
      int[] array_a = new int[n];

      for (int i =0; i < array_a.Length; i++) 
      {
        Console.Write("Enter the number: ");
        array_a[i] = int.Parse(Console.ReadLine());
      }
      int[] result = evenNumberArray(array_a);
      Console.Write("Even numbers in the array are: ");
      foreach (int item in result) 
      {
        Console.Write(item + " ");
      }
    }
  }
}
