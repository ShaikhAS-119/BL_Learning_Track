using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    internal class HashSets
    {
        //create and read
        public static void HashDemo() {
            Console.WriteLine("Element of Hash 1");
            var hashvalue = new HashSet<int>();
            hashvalue.Add(98);
            hashvalue.Add(1);
            hashvalue.Add(2);
            hashvalue.Add(33);
            hashvalue.Add(4);
            foreach (var value in hashvalue)
            {
                Console.Write(" "+value);
            }

            Console.WriteLine("Element of Hash 2");
            var hashvalue2 = new HashSet<int>() {32,65,87,45,};
            foreach (var value in hashvalue2)
            {
                Console.WriteLine($"{value}");
            }

            //remove
            Console.WriteLine("Count is " + hashvalue.Count + "before");
            hashvalue.Remove(4);
            foreach (var value in hashvalue)
            {
                Console.WriteLine($"{value}");
            }
            Console.WriteLine("Count is " + hashvalue.Count + "after");

            //union of 2 set
            Console.WriteLine("after merge: ");
             hashvalue.UnionWith(hashvalue2);
            foreach(var value in hashvalue)
            {
                Console.Write(" "+value);
            }

        }
    }
}
