using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Searching
{
    public class BinarySearch
    {
        public void run()
        {
           // int[] arr=new int[10] { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16 };
            int[] arr = new int[10] { 1,2, 4,5,8,11,16, 20, 90, 98};

            Array.Sort(arr);

            var index = BinSearch(arr, 2);
        }

        public int BinSearch(int[] arr,int key)
        {

            int min = 0;
            int max = arr.Length-1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key < arr[mid]){
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
           


        }
    }
}
