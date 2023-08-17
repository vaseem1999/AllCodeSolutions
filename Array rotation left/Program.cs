using System;
using System.Linq;

namespace arrayRotationLeft 
{
  class Program 
  {
    static int[] left_rev_array(int[] array,int roation ) 
    {
      
      int length = array.Length;
      int[] rev_array = new int[length];

      for (int i = 0; i < length; i++) 
      {
        int index = (i + roation) % length;
        rev_array[i] = array[index];
      }
      return rev_array;
    }

    static void Main(string[] args) 
    {
      Console.WriteLine("Enter the number of elements to be in the array");
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine("No of times to be rotated: ");
      int num = int.Parse(Console.ReadLine());
      int[] array_a = new int[n];
      for (int i = 0; i < n; i++) 
      {
        Console.WriteLine("Enter the values: ");
        array_a[i] = int.Parse(Console.ReadLine());
      }
      int[] result = left_rev_array(array_a,num);
      foreach (int item in result) 
      {
        Console.Write(item + " ") ;
      }

    }
  }
}
