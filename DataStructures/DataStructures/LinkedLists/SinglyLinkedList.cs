using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
    public class SinglyLinkedList
    {
        internal Node head;
    }

    public static class Main
    {
        public static void run()
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            //int[] llistCount = new int[10] { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16 };
            int[] llistCount = new int[10] { 1, 5, 4, 5, 20   , 8, 2, 98, 90, 16 };

            for (int i = 0; i < llistCount.Length; i++)
            {
                int llistItem = llistCount[i]; // Convert.ToInt32(Console.ReadLine());
                Node llist_head = insertNodeAtTail(llist.head, llistItem);
                llist.head = llist_head;

            }

            //var nehead= insertNodeAtPosition(llist.head, 13, 3);
            // var res= deleteNode(llist.head,0);
            //var res = removeDuplicates(llist.head);

            var res = GetNodesFromPosition(llist.head,5);


        }

        static Node reverse(Node head)
        {

            Node current = head;
            Node prev = null;
            Node next = null;

            while (current != null)
            {
                next = current.next;

                current.next = prev;
                prev = current;
                current = next;
            }

            head = prev;
            return head;

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
        public static Node GetLastNode(Node head)
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

        public static Node insertNodeAtPosition(Node head, int data, int position)
        {
            Node new_Node = new Node(data);

            if (head == null && position==0)
                head = new_Node;

   
            Node current = head;
            int count = 1;

            while (count!=position)
            {
                count++;
                current = current.next;
            }

            Node next = current.next;
            current.next = new_Node;
            new_Node.next = next;

            return head;

        }

        static Node deleteNode(Node head, int position)
        {
            if (head == null)
                return null;

            if (position == 0)
            {
                head = head.next;
            }

            Node current = head;
            int count = 1;

            while (count != position)
            {
                current = current.next;
                count++;
            }

            Node prev = current;
            Node temp = prev.next;
            current.next = temp.next;
            temp = null;

            return head;

        }

        static Node removeDuplicates(Node head)
        {
            if (head == null)
                return null;

            Node n = head;
            Node prev = null;

            HashSet<int> set = new HashSet<int>();
            while (n != null)
            {
                if (set.Contains(n.data))
                {
                    prev.next = n.next;
                }
                else
                {
                    set.Add(n.data);
                    prev = n;
                }
               
                n = n.next;
            }

            return head;

        }

        public static Node GetNodesFromPosition(Node head,int start)
        {
            if (head == null)
                return null;

            Node current = head;
            int count = 1;

            while (current != null)
            {
                if (count >= start)
                {
                    Console.WriteLine(current.data);
                }
               
                current = current.next;
                count++;
            }

            return head;
        }
    }
}
