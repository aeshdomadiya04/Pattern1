using System;
using System.Collections.Generic;
using System.Text;

/*
 1
 3 2
 4 5 6
 10 9 8 7
 11 12 13 14 15
 */
namespace Pattern1
{
    internal class pattern5
    {
        public static void Pattern()
        {
            int rows = 5;
            int num = 1;

            for (int i = 1; i <= rows; i++)
            {
                if (i % 2 != 0) // Odd row
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                }
                else // Even row
                {
                    int temp = num + i - 1;

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(temp + " ");
                        temp--;
                    }

                    num += i;
                }

                Console.WriteLine();
            }
        }
    }
}
