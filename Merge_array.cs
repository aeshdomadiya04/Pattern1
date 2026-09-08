using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class Merge_array
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of first array: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[n1];

            Console.WriteLine("Enter first array elements:");
            for (int i = 0; i < n1; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nEnter size of second array: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int[] arr2 = new int[n2];

            Console.WriteLine("Enter second array elements:");
            for (int i = 0; i < n2; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int n = n1 + n2;
            int[] arr = new int[n];
            Console.WriteLine("Merge two array is:");
            for (int i = 0; i < n1; i++)
            {
                arr[i] = arr1[i];
                Console.WriteLine(arr[i]);
            }

            for (int i = 0; i < n2; i++)
            {
                arr[i] = arr2[i];
                Console.WriteLine(arr[i]);
            }







        }
    }
}