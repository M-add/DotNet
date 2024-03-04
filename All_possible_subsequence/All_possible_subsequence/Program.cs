using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_possible_subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");

             string s = Console.ReadLine();

            List<string> result = new List<string>();

            AllSubsequence(s, 0, "", result);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

        public static void AllSubsequence(string s , int index , string current , List<string> result)
        {
            if(index == s.Length)
            {
                result.Add(current);
                return;
            }
            AllSubsequence(s, index + 1, current + s[index], result);
            AllSubsequence(s, index + 1, current, result);
        }
    }
}
