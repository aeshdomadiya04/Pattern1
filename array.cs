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
        }
    }
}
