using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algorithms;

namespace Longest_subsequence
{
    class Program
    {
        static void Main(string[] args)
        {                      
            Class1.longest_subseq();

            //Knapsack
            int[] profit = new int[] { 2 , 3 , 1 , 4 };
            int[] weight = new int[] { 3 , 4 , 6 , 5};
            int W = 8;
            int n = profit.Length;

            // 0/1 knapsack
            Console.WriteLine(Class1.knapsack(W, weight, profit, n));

            //Fractional knapsack
            Class1.fractional_Knapsack(W, weight, profit, n);

            Console.ReadKey();
        }

        
    }
}
