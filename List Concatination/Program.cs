using System;
using System.Linq;
using System.Collections.Generic;

namespace ListConcatination 
{
  class Prorgram 
  {
    static void Main(string[] args) 
    {
      List<int> list_a = new List<int>() {10,20,30,40,50 };
      List<int> list_b = new List<int>() {60,70,80,90,100 };
      List<int> result = list_a.Concat(list_b).ToList();
      Console.WriteLine("Resultant List: " + string.Join(",",result)) ;
      
    }
  }
}

