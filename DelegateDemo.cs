using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    // Declaration
    delegate void MyDelegate(int x, int y);
    class DelegateDemo
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public static void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public static void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public static void Main(string [] args)
        {
            //Instantiation
            MyDelegate obj = new MyDelegate(Add);
            obj += new MyDelegate(Sub);
            obj += Mul;
            obj += Div;
            //obj += Mul;   //also call many methods 
            //obj += Div;
            //obj += Mul;
            //obj += Div;
            //obj += Mul;
            //obj += Div;

            //MyDelegate obj2 = new MyDelegate(Sub);

            //Invocation
            obj(15,5);
            //Add(15, 5);
        }
    }
}
