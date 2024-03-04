using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a sorted list of integers
            List<int> sortedList = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            // Search for an element
            int target = 7;
            int index = sortedList.IndexOf(target);

            // Check the result
            if (index >= 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("fhth");
            }

            var arr = new ArrayList();

            int[] a = { 1, 2, 3, 4, 5 };
            string[] str = { "hi", "hello", "a", "b" };

            arr.AddRange(a);
            arr.AddRange(str);

            foreach(var item in arr)
            {
                Console.WriteLine(item + " ");
            }
            List<string> s = new List<string>();
            foreach (var item in arr)
            {
                if(item is string)
                {
                    s.Add((string)item);
                    //arr.Remove(item);
                }
            }
            s.Sort();
            foreach (var item in s)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadKey();
        }
    }
}
