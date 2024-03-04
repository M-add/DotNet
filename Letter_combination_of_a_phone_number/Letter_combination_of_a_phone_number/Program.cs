using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_combination_of_a_phone_number
{
    class Program
    {
        public static string[] numberPad= {"0" , "1" , "abc" , "def" , "ghi" , "jkl" , "mno" ,"pqrs" , "tuv" , "wxyz"};

        public static void Combinations(string s, int start , string current , List<string> result)
        {
            if(start == s.Length)
            {
                result.Add(current);
                return;
            }

            int d = int.Parse(s[start].ToString());
            string numPad = numberPad[d];

            foreach(char c in numPad)
            {
                Combinations(s, start + 1, current + c, result);
            }
        }


        public static List<string> result = new List<string>();

        static void Main(string[] args)
        {
            string digits = Console.ReadLine();
            int n = digits.Length;

            Combinations(digits, 0, "", result);

            foreach(string s in result)
            {
                Console.Write(s +" ");
            }
            Console.ReadKey();
        }
    }
}
