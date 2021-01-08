using System;
using System.Collections.Generic;

namespace LinkedListSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListOperations linkedListOperatins = new LinkedListOperations();

            linkedListOperatins.AddAtHead(56);
            linkedListOperatins.AddAtHead(30);
            linkedListOperatins.AddAtHead(70);

            linkedListOperatins.DisplayLinkedList();
        }
    }
}
