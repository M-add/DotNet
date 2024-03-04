using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Solution
{
    public static int[][] Insert(int[][] intervals, int[] newi)
    {
        int n = intervals.Length;
        List<int[]> res = new List<int[]>();

        int i = 0;

        while (i < n && intervals[i][1] < newi[0])
        {
            res.Add(intervals[i]);
            i++;
        }

        while (i < n && intervals[i][0] <= newi[1])
        {
            newi[0] = Math.Min(newi[0], intervals[i][0]);
            newi[1] = Math.Max(newi[1], intervals[i][1]);
            i++;
        }

        res.Add(newi);

        while (i < n)
        {
            res.Add(intervals[i]);
            i++;
        }

        return res.ToArray();
    }

    public static void Main(string[] args)
    {    
        int[][] intervals = new int[1][];
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine($"Enter the start of interval {i + 1}:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter the end of interval {i + 1}:");
            int end = int.Parse(Console.ReadLine());

            intervals[i] = new int[] { start, end };
        }

        while (true)
        {
            Console.WriteLine("Enter a new interval to merge (enter 'q' to quit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                break;
            }

            int[] newInterval = Array.ConvertAll(input.Split(' '), int.Parse);
            intervals = Insert(intervals, newInterval);

            Console.WriteLine("Merged Intervals:");
            foreach (var interval in intervals)
            {
                Console.WriteLine($"[{interval[0]}, {interval[1]}]");
            }
        }
    }
}

