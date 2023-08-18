using System;
using System.Linq;
using System.Collections.Generic;

namespace ListIntersection 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      List<int> list_a = new List<int>() {10,20,3,040,20,};
      List<int> list_b = new List<int>() {10,3,420,20 };
      List<int> resultantList = list_a.Union(list_b).ToList();
      Console.WriteLine("IntersectList: " + string.Join(",", resultantList));
    }
  }
}