using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Strings
{
    public static class Permutation
    {
        public static void run()
        {
            String str = "ABC";
            int n = str.Length;
            permute(str, 0, n - 1);
        }
        public static void permute(string str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {

                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }

        }

        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }


        public static void reverseSentence(string text)
        {

            string[] str = text.Split(" ");
            StringBuilder sb = new StringBuilder();


            for (int i = str.Length-1; i >= 0; i--)
            {
                sb.Append(reverse(str[i]+" "));
            }

            Console.WriteLine(sb.ToString());
        }

        public static string reverse(string str)
        {

            StringBuilder s = new StringBuilder();

            for (int i = str.Length-1; i >= 0; i--)
            {
                s.Append(str[i]);

            }

            return s.ToString();
        }

        public static string reverseInPlace(char[] str,int start,int end)
        {

            while (start < end)
            {
                str[start] ^= str[end];  // str[start]= str[start] ^ str[end] 

                str[end] ^= str[start];  // str[end] = str[end] ^ ( str[start] ^ str[end]  ) =  str[start]  ^ ( str[end] ^ str[end]  ) =  str[start]

                str[start] ^= str[end];  // str[start] = str[start] ^ str[end] =  ( str[start] ^ str[end]  ) ^ str[start] = (str[start] ^ str[start] ) ^   str[end] = str[end]

                ++start;
                --end;
            }

            return String.Join("", str);
        }

        public static Boolean IsPermutation(string str1,string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            return sortStr(str1).Equals(sortStr(str2));
        }
        public static string sortStr(string str)
        {   

            Char[] content = str.ToCharArray();
            Array.Sort(content);
            var x=str.Replace(" ", "%20");
            return new String(content);
        }
    }
}
