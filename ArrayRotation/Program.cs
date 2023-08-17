using System;
using System.Linq;

namespace Arrayrotaion 
{
  class Program
  {

    static int[] rev_array(int[] array,int n)
    {
      int length = array.Length;
      int[] rev_ar = new int[length];
      for (int i =0; i < length; i++) 
      {
        int index = (i - n + length) % length;
        rev_ar[i] = array[index]; 
      }
      return rev_ar;
    }
    static void Main(string[] args) 
    {
      Console.WriteLine("Enter the number of elements to be in a array");
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine("No of times to rotate: ");
      int no_of_rotations = int.Parse(Console.ReadLine());  

      int[] array_a = new int[n];

      for (int i = 0; i < n; i++)
      {
        Console.Write("Enter number: ");
        array_a[i] = int.Parse(Console.ReadLine());
      }
      int[] result = rev_array(array_a, no_of_rotations);
      foreach (int item in result) 
      {
        Console.WriteLine(item + " ") ;
      }
    }
  }
}
