using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_sum
{
    public static class Class1
    {
        public static HashSet<string> pal = new HashSet<string>();
        public static int maxlen = 0;
        public static int longestpal(string input)
        {
            int n = input.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    string s = input.Substring(i, j);
                    //Console.WriteLine(s);
                    permute(s, 0, s.Length - 1);
                }
            }

            int count = 0;
            
            foreach (string palindrome in pal)
            {
                if (palindrome.Length == maxlen)
                {
                    count++;
                }
            }
            maxlen = 0;
            pal.Clear();
            return count;
            //Console.WriteLine(count);
        }
        public static void permute(string str, int l, int r)
        {
            if (l == r)
            {
                //pal.Add(str);
                if (checkpalindrome(str))
                {
                    pal.Add(str);
                    if (str.Length > maxlen)
                    {
                        maxlen = str.Length;
                    }
                }
            }
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
        public static string swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        public static bool checkpalindrome(string s)
        {
            int n = s.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (s[i] != s[n - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
