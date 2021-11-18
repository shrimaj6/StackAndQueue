using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }


        }
    }
}
