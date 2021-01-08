using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListSolution
{
    class LinkedListOperations
    {
        public Node head;
        public void AddAtHead(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                head = temp.next;
            }
            Console.WriteLine("{0} added to the linked list ", node.data);
        }
        public void DisplayLinkedList()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty ");
            }
            Console.WriteLine("Whole Linked List ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
