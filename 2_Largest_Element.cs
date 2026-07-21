using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class _2_Largest_Element
    {
        public static void Largest()
        {
            //2nd largest element in an array
            int n, largest;
            int? secondlargest;

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

            largest = arr[0];
            secondlargest = null;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > largest)
                {
                    secondlargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] < largest && (secondlargest == null || arr[i] > secondlargest))
                {
                    secondlargest = arr[i];
                }
            }

            Console.WriteLine("\nLargest Element = " + largest);
            if (secondlargest.HasValue)
                Console.WriteLine("Second Largest Element = " + secondlargest.Value);
            else
                Console.WriteLine("Second Largest Element not found.");
        }
    }
}
