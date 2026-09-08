using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class Reverse_array
    {
        static void Main(string[] args)
        {
            int n, i;

            Console.Write("Enter size of arrray:");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array element " + i + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int start = 0;
            int end = n - 1;

            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;


                start++;
                end--;
            }

            Console.WriteLine("Reverse array:");

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}