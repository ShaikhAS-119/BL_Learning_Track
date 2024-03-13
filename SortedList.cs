using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    internal class SortedList
    {
        public static void SListsDemo()
        {
            SortedList<object,object> sortedlist = new SortedList<object,object>();
            sortedlist.Add(3,"hello");
            sortedlist.Add(4, null);
            sortedlist.Add(5, 45);
            sortedlist.Add(6, 98);

            //foreach(object item in sortedlist) 
            //{
            //    Console.WriteLine(item);
            //}

            //for(int i = 0; i <= sortedlist.Count; i++)
            //{
            //    Console.WriteLine(sortedlist[i]);
            //}
        }
    }
}
