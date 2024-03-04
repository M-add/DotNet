using System;
using System.Collections.Generic;

class Solution
{
    static int NonDivisibleSubset(int k, List<int> S)
    {
        // Initialize a dictionary to store the count of elements with each remainder
        Dictionary<int, int> remainderCount = new Dictionary<int, int>();

        // Count the number of elements with each remainder
        foreach (int num in S)
        {
            int remainder = num % k;
            if (remainderCount.ContainsKey(remainder))
                remainderCount[remainder]++;
            else
                remainderCount[remainder] = 1;
        }

        // Initialize the result to the minimum of remainderCount[0] and 1
        int result;
        if (remainderCount.TryGetValue(0, out int count))
        {
            result = Math.Min(count, 1);
        }
        else
        {
            result = 1;
        }
        int count1 = 0, count2 = 0;

        // Calculate the maximal subset length
        for (int i = 1; i <= k / 2; i++)
        {
            if (i != k - i)
            {

                if (remainderCount.TryGetValue(i, out count1) && remainderCount.TryGetValue(k - i, out count2))
                {
                    result += Math.Max(count1, count2);
                }
            }

        }

        // If k is even and there are elements with remainder k / 2, add 1 to the result
        if (k % 2 == 0)
            result += 1;

        foreach (var t in remainderCount)
        {
            Console.WriteLine($"kEY : {t.Key} Value : {t.Value}");
        }
        // Print the dictionary values
        foreach (var t in remainderCount)
        {
            Console.WriteLine($"Key: {t.Key}, Value: {t.Value}");
        }
        return result;
    }

    static void Main(string[] args)
    {
        // Input
        string[] nk = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(nk[0]);
        int k = Convert.ToInt32(nk[1]);
        List<int> S = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32));

        // Calculate and print the length of the maximal subset
        int result = NonDivisibleSubset(k, S);

        Console.WriteLine(result);

        Console.ReadKey();
    }

}
