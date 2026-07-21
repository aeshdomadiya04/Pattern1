using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class _2_smallest_element
    {
        public static void Smallest()
        {
            //2nd smallest element in an array
            int n, smallest;
            int? secondsmallest;
            Console.Write("Enter no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (n == 0)
            {
                Console.WriteLine("No elements.");
                return;
            }
            smallest = arr[0];
            secondsmallest = null;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < smallest)
                {
                    secondsmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] > smallest && (secondsmallest == null || arr[i] < secondsmallest))
                {
                    secondsmallest = arr[i];
                }
            }
            Console.WriteLine("\nSmallest Element = " + smallest);
            if (secondsmallest.HasValue)
                Console.WriteLine("Second Smallest Element = " + secondsmallest.Value);
            else
                Console.WriteLine("Second Smallest Element not found.");
        }
    }
}
