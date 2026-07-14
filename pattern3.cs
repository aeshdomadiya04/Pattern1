using System;
using System.Collections.Generic;
using System.Text;

/*
 1
 1 3
 1 3 5
 1 3 5 7
 1 3 5 7 9
 */
namespace Pattern1
{
    internal class pattern3
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
                    k= k + 2;
                }
                k = 1;
                Console.WriteLine();
            }
        }
    }
}
