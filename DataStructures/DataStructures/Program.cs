using DataStructures.LinkedLists;
using DataStructures.Trees;
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //SinglyLinkedList llist = new SinglyLinkedList();

            //Node llist_head = insertNodeAtTail(llist.head, 5);
            //llist.head = llist_head;

            //Node llist_head1 = insertNodeAtTail(llist.head, 6);
            //llist.head = llist_head1;

            //Node llist_head2 = insertNodeAtTail(llist.head, 7);
            //llist.head = llist_head2;

            Console.ReadKey();

            Console.WriteLine("Hello World!");
        }
        static Node insertNodeAtTail(Node head, int data)
        {

            Node new_node = new Node(data);

            if (head == null)
            {
                head = new_node;

            }
            else
            {
                var lastNode = GetLastNode(head);
                lastNode.next = new_node;
            }

            return head;
        }
        static Node GetLastNode(Node head)
        {

            if (head.next == null)
                return head;

            Node temp;
            temp = head.next;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }
    }
}
