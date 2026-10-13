using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    internal class CollectionTest
    {
        public static void Main(string[] args)
        {
            //create an object of List collection
            ArrayList obj = new ArrayList();

            obj.Add("RKU");
            obj.Add(110);
            obj.Add(152.65);
            obj.Add('A');
            obj.Add(true);

            //fetch the data from collection
            Console.WriteLine("Number of Element:"+ obj.Count);
        }
    }
}
