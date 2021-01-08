using System;
using System.Collections.Generic;

namespace LinkedListSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListOperations linkedListOperations1 = new LinkedListOperations();
            LinkedListOperations linkedListOperations2 = new LinkedListOperations();

            linkedListOperations1.AddAtHead(70);
            linkedListOperations1.AddAtHead(30);
            linkedListOperations1.AddAtHead(56);
            linkedListOperations1.DisplayLinkedList();

            linkedListOperations2.AddAtLast(56);
            linkedListOperations2.AddAtLast(30);
            linkedListOperations2.AddAtLast(70);
            linkedListOperations2.DisplayLinkedList();
        }
    }
}
