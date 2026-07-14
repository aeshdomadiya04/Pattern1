using System;
using System.Collections.Generic;
using System.Text;

/*
1
2 3
4 5 6
7 8 9 10
11 12 13 14 15
 */
namespace Pattern1
{
    internal class pattern4
    {
        public static void Pattern()
        {   // extra variable
            int k = 1;
            for (int i = 1; i <= 5; i++) //no. of rows
            {
                for (int j = 1; j <= i; j++) //no.of cols
                {
                    // calculation if required
                    Console.Write(k + " "); // printing
                    k = k + 1;
                }
                Console.WriteLine();
            }
        }
    }
}
