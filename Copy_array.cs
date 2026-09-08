using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class Copy_array
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            Console.WriteLine("Enter array element:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Original array:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr1[i] + " ");

            }


            Console.WriteLine("coppied array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr2[i] + " ");

            }

        }
    }
}