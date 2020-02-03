using DataStructures.HashTables;
using DataStructures.LinkedLists;
using DataStructures.Queues;
using DataStructures.Searching;
using DataStructures.Sorting;
using DataStructures.Strings;
using System;
using System.Collections;
using System.Text;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str= "you can cage a swallow can't you?";
            ////string str = "you shall not pass";
            //Permutation.reverseSentence(str);

            //SortingAlgorithms S = new SortingAlgorithms();
            //S.run();
            //BinarySearch bin = new BinarySearch();
            //bin.run();
            //Permutation.run();
            ////FindPair.Main.run();
            //string str = "ABCDEF";
            //string sub = str.Substring(0, 2);
            //Console.WriteLine(sub);
            //StringBuilder sb = new StringBuilder();

            //ArrayList arrList = new ArrayList();

            //arrList.Add(1);

            //for(int i=0; i < arrList.Count; i++)
            //{
            //    var n = arrList[i];
            //}

            //sb.Append("my name is");
            //sb.Append("");

            //LinkedLists.Main.run();
            MyQueue<int> myQueue = new MyQueue<int>();
            myQueue.run();

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
