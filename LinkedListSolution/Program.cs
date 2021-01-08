using System;
using System.Collections.Generic;

namespace LinkedListSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);

            foreach(int value in linkedList)
            {
                Console.Write(value + " ");
            }
        }
    }
}
