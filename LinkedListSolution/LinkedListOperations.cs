using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListSolution
{
    public class LinkedListOperations
    {
        public Node head;
        public void AddAtHead(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
            Console.WriteLine("{0} added to the first Position of linked list ", node.data);
        }
        public void AddAtLast(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
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
            Node temp = head;
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
        public int Search(int value)
        {
            Node node = head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public Node InsertAtParticularPosition(int position, int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                return newNode;
            }
            if (position == 0)
            {
                newNode.next = head;
                head = newNode;
                return head;
            }
            Node prev = null;
            Node current = head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            prev.next = newNode;
            return head;
        }
        internal Node RemoveFirstNode()
        {
            if (head == null)
            {
                return null;
            }
            head = head.next;
            return head;
        }
        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        public int Size()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            return count;
        }
        public Node DeleteNodeByValue(int value,int position)
        {
            Node prev = null;
            Node current = head;
            //int position = Search(value);
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            prev.next = current.next;
            current.next = null;
            return head;
        }
    }
}
