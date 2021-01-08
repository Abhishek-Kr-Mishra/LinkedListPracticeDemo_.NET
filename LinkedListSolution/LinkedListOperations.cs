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
            //if (head == null)
            //{
            //    this.head = node;
            //    node.next = null;
            //}
            //else
            //{
                node.next = head;
                head = node;
            //}
            Console.WriteLine("{0} added to the first Position of linked list ", node.data);
        }
        public void AddAtLast(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} added to the last position of linked list ", node.data);
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
