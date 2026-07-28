using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class binary_search
    {
        public static void BinarySearch()
        {
            // Binary search algorithm
            int n, element;
            Console.Write("Enter no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr); // Sort the array for binary search
            Console.Write("Enter the element to search: ");
            element = Convert.ToInt32(Console.ReadLine());
            int left = 0, right = n - 1, index = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == element)
                {
                    index = mid;
                    break;
                }
                else if (arr[mid] < element)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            if (index != -1)
                Console.WriteLine("Element " + element + " found at index " + index + ".");
            else
                Console.WriteLine("Element " + element + " not found in the array.");
        }
    }
}
