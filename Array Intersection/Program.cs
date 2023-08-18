using System;
using System.Linq;

namespace ArrayIntersection 
{
  class Program 
  {
    static int[] array(int n) 
    {
      int[] array_a = new int[n];
      for (int i =0; i < n; i++) 
      {
        Console.WriteLine("Enter the value: ");
        array_a[i] = int.Parse(Console.ReadLine()); 
      }
      Console.WriteLine("array ends");
      return array_a;
    }
    static void Main(string[] args) 
    {
      Console.WriteLine("Enter the no of element to be in a array_a: ");
      int n = int.Parse(Console.ReadLine()); //define the length of an array 
      Console.WriteLine("Enter the no of element to be in a array_b: ");
      int m = int.Parse(Console.ReadLine());

      int[] array_a = array(n);
      int[] array_b = array(m);

      int[] array_c = array_a.Intersect(array_b).ToArray();
      Console.WriteLine("Intersect array: " + string.Join(",",array_c));

     Console.WriteLine("array_a: " + string.Join(", ", array_a));
     Console.WriteLine("array_b: " + string.Join(", ",array_b));

    }
  }
}