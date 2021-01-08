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
            linkedListOperations1.AddAtHead(56);
            linkedListOperations1.DisplayLinkedList();

            linkedListOperations2.AddAtLast(56);
            linkedListOperations2.AddAtLast(30);
            linkedListOperations2.AddAtLast(70);
            linkedListOperations2.DisplayLinkedList();

            int positionOf56th = linkedListOperations1.Search(56);
            int positionOf70th = linkedListOperations1.Search(70);
            if ((positionOf70th - positionOf56th) == 1)
            {
                linkedListOperations1.InsertAtParticularPosition(positionOf56th + 1, 30);
                Console.WriteLine("List after inserting 30 between 56 and 70");
            }
            linkedListOperations1.DisplayLinkedList();
        }
    }
}
