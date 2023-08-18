using System;
using System.Linq;
using System.Collections.Generic;

namespace listsPractice 
{
  class Program 
  {
   static int sumOfElements(List<int> list) 
    {
      int sum = 0;
      foreach (int element in list) 
      {
        sum += element;
      }
      return sum;
    }
    static void Main(string[] args) 
    {
      List<int> list_a = new List<int>();
      Console.WriteLine("Num of elemts to be in a list: ");
      int num = int.Parse(Console.ReadLine());

      for (int i = 0; i < num; i++) 
      {
        Console.WriteLine("Enter value here: ");
        list_a.Add(int.Parse(Console.ReadLine()));
      }
      int result = sumOfElements(list_a);
      Console.WriteLine(result);
    }
  }
}