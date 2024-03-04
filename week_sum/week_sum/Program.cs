using System;
using System.Collections.Generic;
using week_sum;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Enter a string:");
        //string input = Console.ReadLine();

        //int result = Class1.longestpal(input);

        //Console.WriteLine("Maximum Palindromes:");
        //Console.WriteLine(result);

        int[] arr = new int[16]
        {
            113,242,
            134,267,
            154,291,
            171,321,
            179,344,
            190,315,
            207,296,
            202 , 156
        };

        foreach(int i in arr)
        {
            float f = ((float)i / 350f) * 100;
            Console.WriteLine(Math.Round(f, 1) + "  ");
        }
        Console.ReadKey();
    }
}
