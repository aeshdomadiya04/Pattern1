using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class find_first_occurrences_element
    {
        public static void FindFirstOccurrence()
        {
            // Find the first occurrence of an element in an array
            int n, element;
            Console.Write("Enter no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the element to find first occurrence: ");
            element = Convert.ToInt32(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == element)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
                Console.WriteLine("First occurrence of element " + element + " is at index " + index + ".");
            else
                Console.WriteLine("Element " + element + " not found in the array.");
        }
    }
}
