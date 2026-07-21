using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class Positive_Negative_Zero
    {
        public static void pnz()
        {
            int n, num;
            int positive = 0, negative = 0, zero = 0;
            Console.Write("Enter no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number " + i + ": ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    positive++;
                }
                else if (num < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }
            Console.WriteLine("\nTotal Positive Numbers = " + positive);
            Console.WriteLine("Total Negative Numbers = " + negative);
            Console.WriteLine("Total Zero Numbers = " + zero);
        }
    }
}
