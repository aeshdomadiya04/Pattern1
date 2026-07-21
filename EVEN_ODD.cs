using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class EVEN_ODD
    {
        public static void eo()
        {
            //count the even and odd numbers
            int n, num;
            int even = 0, odd = 0;

            Console.Write("Enter no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number " + i + ": ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine("\nTotal Even Numbers = " + even);
            Console.WriteLine("Total Odd Numbers = " + odd);

        }
    }
}
