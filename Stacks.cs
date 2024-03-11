using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    internal class Stacks
    {
        public static void StackDemo()
        {
           
            //1 operation
            Stack<int > stack = new Stack<int>();
            stack.Push(34);
            stack.Push(98);
            stack.Push(65);
            stack.Push(12);
         

            foreach (int i in stack)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            //2nd operation
            Console.WriteLine("peek elemnt "+stack.Peek());
            //3rd operation
            stack.Pop();

            foreach (int i in stack)
            {
                Console.Write(" "+i);
            }
            //4th operation
            //stack.Clear();

            //clone
            //5th operation
            Stack<int> stack2 = stack;
            Console.WriteLine("after clone");

            PrintStacks(stack2);
            Console.WriteLine("clone done");

            //check null value is acceptable 
            Stack<Object> stack3 = new Stack<object>();
            stack3.Push(null);
            Console.WriteLine("Count is with null "+stack3.Count);

        }
        public static void PrintStacks(Stack<int> s) { 
            foreach(int i in s)
            {
                Console.Write(" " + i);
            }
        
        }
    }
}
