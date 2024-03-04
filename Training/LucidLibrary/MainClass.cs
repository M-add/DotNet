using System;
using System.IO;
using System.Text;

namespace LucidLibrary
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "S";

            Console.WriteLine(s.Greet(8));

            Console.ReadKey();
        }
    }

    static class stringExtentions
    {
        public static string Greet(this string value, int count)
        {
            return "hello "+ value;
        }
    }
}
