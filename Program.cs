using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            stack.Pop();

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            Console.WriteLine(stack.Peek());



        }
    }
}
