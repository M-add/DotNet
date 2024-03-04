using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newclass;
namespace ConsoleApp8
{
    class Program
    {
        public static List<string> permutations = new List<string>();

        public static void permute(String str, int l, int r)
        {
            if (l == r)
                //Console.WriteLine(str);
                permutations.Add(str);
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

        public static bool checkPal(string s)
        {
            int n = s.Length;

            for (int i = 0; i < n / 2; i++)
            {
                if(s[i] != s[n-i-1])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            //Class1.swapcount();
            //Class1.matrix();

            String str = Console.ReadLine();
            int n = str.Length;


            HashSet<string> uniq_per = new HashSet<string>();

            int k = 0;
            while(k < n-2)
            {
                string temp = ""+ str[k];
                for (int i = 0; i < n; i++)
                {
                    if(i != k)
                    {
                        temp += str.Substring(i, n - i);
                        //Console.WriteLine(temp);
                        uniq_per.Add(temp);
                        temp = "";
                        temp += str[k];
                    }
                }
                //Console.WriteLine( temp );
                k++;
            }

            foreach (string item in uniq_per)
            {
                Console.WriteLine("===>"+""+item);
            }

            //List<string> palindrome = new List<string>();
            //foreach(string item in permutations)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (string item in permutations)
            //{
            //    if(checkPal(item))
            //    {
            //        palindrome.Add(item);
            //    }
            //}

            //foreach(string pal in palindrome)
            //{
            //    Console.WriteLine(pal);
            //}

            Console.ReadKey();
        }
    }
}
