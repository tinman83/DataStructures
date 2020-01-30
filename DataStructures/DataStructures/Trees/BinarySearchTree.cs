using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
   public class BinarySearchTree
    {
        public class BinTreesMain
        {
            public void Run()
            {
                BinarySearchTree nums = new BinarySearchTree();

                nums.Insert(50);
                nums.Insert(17);
                nums.Insert(23);
                nums.Insert(12);
                nums.Insert(19);
                nums.Insert(54);
                nums.Insert(9);
                nums.Insert(14);
                nums.Insert(67);
                nums.Insert(76);
                nums.Insert(72);
            }
        }
        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;
            public void DisplayNode()
            {
                Console.WriteLine(Data + " ");
            }
        }

        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;

            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                break;
                            }
                        }

                    }
                }
            }

        }
    }
}
