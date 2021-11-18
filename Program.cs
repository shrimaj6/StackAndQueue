using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> S1 = new Stack<int>();

            S1.Push(56);
            S1.Push(30);
            S1.Push(70);

            foreach(var element in S1)
            {
                Console.WriteLine(element);
            }



        }
    }
}
