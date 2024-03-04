using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    public static class Class1
    {
        //Longest subsequence
        public static void longest_subseq()
        {
            Console.WriteLine("Enter string 1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter string 2:");
            string s2 = Console.ReadLine();

            int n = s1.Length;
            int m = s2.Length;

            int[,] dp = new int[n + 1, m + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else if(s1[i-1] == s2[j-1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            int index = dp[n,m];
            int temp = index;

            char[] lcs = new char[index + 1];
            lcs[index] = '\0';

            int k = n, l = m;

            while (k > 0 && l > 0) 
            {
                if (s1[k - 1] == s2[l - 1])
                {
                    lcs[index - 1] = s1[k - 1];
                    k--;
                    l--;
                    index--;
                }
                else if (dp[k - 1, l] > dp[k, l - 1])
                {
                    k--;
                }
                else
                {
                    l--;
                }
            }

            Console.WriteLine("The longest common subsequence is:");
            for (int i = 0; i <= temp; i++)
            {
                Console.Write(lcs[i] + " ");
            }
            Console.WriteLine();
        }

        //Knapsack 0/1
        public static int knapsack(int W, int[] wt, int[] val, int n)
        {
            int i, w;
            int[,] dp = new int[n + 1, W + 1];

            for (i = 0; i <= n; i++)
            {
                for (w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                    {
                        dp[i, w] = 0;
                    } 
                    else if (wt[i - 1] <= w)
                    {
                        dp[i, w] = Math.Max(val[i - 1] + dp[i - 1, w - wt[i - 1]], dp[i - 1, w]);
                    }
                        
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }                       
                }
            }

            //Print
            Console.WriteLine("Selected items and their profits:");

            int j = W;
            for (i = n; i > 0 && dp[i, j] > 0; i--)
            {
                if (dp[i, j] != dp[i - 1, j])
                {
                    Console.WriteLine($"Weight: {wt[i - 1]}, Profit: {val[i - 1]}");
                    j -= wt[i - 1];
                }
            }
            return dp[n, W];
        }

        //Fractional knapsack
        public static void fractional_Knapsack(int W, int[] wt, int[] val, int n)
        {
            List<KeyValuePair<int, double>> items = new List<KeyValuePair<int, double>>();

            for(int i = 0; i < n; i++) 
            {
                double currentFraction = (double)val[i] / wt[i];
                items.Add(new KeyValuePair<int, double>(i, Math.Round(currentFraction, 1)));
            }

            items.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            double profit = 0;
            foreach(var pair in items)
            {
                if(wt[pair.Key] < W)
                {
                    profit += val[pair.Key];
                    W -= wt[pair.Key];
                }
                else
                {
                    double fraction = (double)(val[pair.Key] * W) / wt[pair.Key];
                    profit += fraction;
                    break;
                }
            }
            Console.WriteLine(profit);
        }
    }
}
