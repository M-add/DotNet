using System;
using System.Collections.Generic;

class Program
{
    //static List<List<int>> coin_combinations(int[] coins, int amount)
    //{
    //    List<List<int>> result = new List<List<int>>();
    //    List<int> comb = new List<int>();
    //    combinations(coins, amount, 0, comb, result);
    //    return result;
    //}
    public static List<List<int>> result = new List<List<int>>();

    static void combinations(List<int> coins, int r_amount, int start, List<int> comb, List<List<int>> result)
    {
        if (r_amount == 0)
        {
            result.Add(new List<int>(comb));
            return;
        }

        if (r_amount < 0)
        {
            return;
        }

        for (int i = start; i < coins.Count; i++)
        {
            if(r_amount >=coins[i] )
            {
                comb.Add(coins[i]);
                combinations(coins, r_amount - coins[i], i, comb, result);
                comb.RemoveAt(comb.Count - 1);
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter the amount:");
        int amount = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of coins:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the coins:");
        List<int> coins = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            coins.Add(temp);
        }
        HashSet<int> c = new HashSet<int>(coins);
        coins.Clear();
        coins.AddRange(c); 

        List<int> comb = new List<int>();
        combinations(coins, amount, 0, comb, result);

        Console.WriteLine("All possible coin combinations:");

        foreach (List<int> items in result)
        {
            Console.Write("[ ");
            foreach(int item in items)
            {
                Console.Write(item +" ");
            }
            Console.Write(" ]");
            Console.WriteLine();
        }

        Console.WriteLine($"Total number of unique combinations: {result.Count}");

        Console.ReadKey();
    }
}
