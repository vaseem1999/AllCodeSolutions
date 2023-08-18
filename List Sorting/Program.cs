using System;
using System.Linq;
using System.Collections.Generic;

namespace ListSorting 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      List<int> list_a = new List<int>() {80,50,40,70,30};
      list_a.Sort((x,y) => y.CompareTo(x));//compare in descending order
      list_a.Sort((x, y) => x.CompareTo(y));//Compare in ascending order
      Console.WriteLine("Sorted list: " + string.Join(",",list_a));

    }
  }
}
