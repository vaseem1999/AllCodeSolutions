using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxElements 
{
  class Program 
  {
    static int MaxNumber(List<int> list) 
    {
      int max_num = list.Max();
      return max_num;
    }
    static void Main(string[] args) 
    {
      List<int> list_a = new List<int>();
      Console.WriteLine("Number of elements to be in list: ");
      int num = int.Parse(Console.ReadLine());
      for (int i =0; i < num; i++)
      {
        Console.Write("Enter values: ");
        int v = int.Parse(Console.ReadLine());
        list_a.Add(v);
      }
      Console.WriteLine("list_a contains: " + string.Join(",", list_a));

      Console.WriteLine("Max Num is: " + MaxNumber(list_a));
    }
  }
}
