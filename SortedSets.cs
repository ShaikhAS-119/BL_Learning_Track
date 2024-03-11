using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    internal class SortedSets
    {
        public static void SortedSetDemo()
        {
            //create and read
            Console.WriteLine("First SortedSet");
            SortedSet<int> values = new SortedSet<int> ();
            values.Add(8);
            values.Add(6);
            values.Add(2);
            values.Add(9);
            foreach (int i in values)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine();

            Console.WriteLine("second SortedSet");
            SortedSet<string> values2 = new SortedSet<string>() { "Today", "We", "Practiced", "Collections" };
            foreach (string val in values2)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("max num is "+values.Max);
            Console.WriteLine("Min is "+ values2.Min);

            Console.WriteLine("Count of first set: " + values.Count);
            values.Remove(6);
            Console.WriteLine("Count of first set: " + values.Count);

            Console.WriteLine("Count of sec set: " + values2.Count);
            values2.Remove("We");
            Console.WriteLine("Count of sec set: "+ values2.Count);

        }
    }
}
