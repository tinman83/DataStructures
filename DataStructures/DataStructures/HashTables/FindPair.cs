using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashTables
{
    public class FindPair
    {
        public static class Main{

            public static void run()
            {
               

                int[] list = new int[10] { 1 , 7 , 5 , 9, 2 ,12, 3,15,20,30 };

                var dict = GetDictionary(list);

                int pairCount=0;
                foreach(var item in dict)
                {
                    int num = item.Key;
                    if(dict.ContainsKey((num+2)) || dict.ContainsKey((num - 2))){
                        Console.WriteLine("*********");
                        Console.WriteLine(num);
                        Console.WriteLine(num + 2);
                        Console.WriteLine(num -2);
                        Console.WriteLine("*********");
                        pairCount++;
                    }
                    
                }

                Console.WriteLine(pairCount);
            }

            static Dictionary<int,int> GetDictionary(int[] arr)
            {
                Dictionary<int, int> Dict = new Dictionary<int, int>();

                for(int i = 0; i < arr.Length; i++)
                {
                    if (!Dict.ContainsKey(arr[i])){
                        Dict.Add(arr[i], 0);
                    }
                }

                return Dict;
            }
        }
    }
}
