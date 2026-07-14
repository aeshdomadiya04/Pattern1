using System;
using System.Collections.Generic;
using System.Text;

/*
 * 
 * *
 * * *
 * * * *
 * * * * *
 */
    
/*
 1
 1 2
 1 2 3
 1 2 3 4
 1 2 3 4 5
 */

namespace Pattern1
{
    internal class pattern2
    {
        public static void Pattern()
        {
            for (int i = 1; i <= 5; i++) //no. of rows
            {
                for (int j = 1; j <= i; j++) //no.of cols
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

namespace Pattern1
{
    internal class pattern
    {
        public static void Pattern()
        {
            for (int i = 1; i <= 5; i++) //no. of rows
            {
                for (int j = 1; j <= i; j++) //no.of cols
                {
                    Console.Write(j+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
