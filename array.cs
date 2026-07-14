using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class array
    {
        public static void Array()
        {
            int[] a = new int[5];

            //task - 1 = input 5 elements into this array 
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + ":");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            //task 2 = print array elements
            Console.WriteLine("The elements in the array are:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            //task 3 = find and print sum and avg of all elements
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum = sum + a[i];
                    Console.WriteLine(a[i]);
                }
                Console.WriteLine("Sum: " + sum);
                float avg = sum / 5;
                Console.WriteLine("Avg: " + avg);
            }

            // task 4 = find and print the min and max of all elements
            {
                int min = a[0];
                int max = a[0];

                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
                Console.WriteLine("Min: " + min);
                Console.WriteLine("Max: " + max);
            }
        }
    }
}
