using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class find_array_element
    {
        public static void FindElement()
        {
            // Find an element in an array
            int n, element;
            Console.Write("Enter no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the element to find: ");
            element = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == element)
                {
                    found = true;
                    break;
                }
            }
            if (found)
                Console.WriteLine("Element " + element + " found in the array.");
            else
                Console.WriteLine("Element " + element + " not found in the array.");
        }
    }
}
