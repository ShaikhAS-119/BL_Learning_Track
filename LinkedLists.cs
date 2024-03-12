using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    internal class LinkedLists
    {
         public LinkedLists()
        {
            
            LinkedListDemo();
        }
        public static  void LinkedListDemo()
        {
            LinkedList<object> linkedList = new LinkedList<object>();
            //add at End of linkedlist
            linkedList.AddLast(23);
            linkedList.AddLast("hello");
            linkedList.AddLast(87);

            linkedList.Remove(23);

            //add at start of linkedlist
            linkedList.AddFirst(65);
            //count the element
            Console.WriteLine("Count is "+linkedList.Count);
            Console.WriteLine();

            LinkedListNode<object> node = linkedList.Find("hello");
            //node added after element
            linkedList.AddAfter(node, 100);
            //node added before element
            linkedList.AddBefore(node, "and welcome");



            foreach (object item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
