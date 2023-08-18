using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveDuplicates 
{
  class Program 
  {
    static List<int> removeDuplicats(List<int> list) 
    {
      HashSet<int> result = new HashSet<int>(list);
      return result.ToList();
    }
    static void Main(string[] args) 
    {
      Console.WriteLine("Num of elements to be in the list: ");
      List<int> list_a = new List<int>();
      int num = int.Parse(Console.ReadLine());
      for (int i = 0; i < num; i++) 
      {
        Console.WriteLine("Enter the values: ");
        int v = int.Parse(Console.ReadLine());  
        list_a.Add(v);
      }
      Console.WriteLine("List_a contains: " + string.Join(", ", list_a));
      List<int> unique_list = removeDuplicats(list_a);
      Console.WriteLine("Unique list: " + string.Join("," , unique_list));
    }
  }
}
