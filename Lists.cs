using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Data_Structure
{
    internal class Lists
    {
        public static void ListDemo()
        {
            //using for loop
            //Console.WriteLine("first list");
            var list = new List<string>();
            list.Add(" one");
            list.Add(" two");
            list.Add(" three");

            //for(int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]); 
            //}

            // using foreach loop
            //List<int> list1 = new List<int>();
            //list1.Add(8);
            //list1.Add(1);
            //list1.Add(7);

            ////sorting
            //list1.Sort();
            ////reverse
            //list1.Reverse();
            ////
            //foreach(int i in list1)
            //{
            //    Console.WriteLine(i);
            //}

            //list using array/ collection initializer

            var listarray = new List<string>() { " pune", " Thane", " Bhiwandi", " Nashik" };
            //for(int i = 0; i <= listarray.Count; i++)
            //{
            //    Console.WriteLine(listarray[i]);    
            //}
            listarray.AddRange(list);

            foreach (var item in listarray)
            {
                Console.Write(item);
            }


        }
    }
}
