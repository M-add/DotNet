using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_intervals
{
    class Program
    {
        public static int[,] arr = new int[100, 2];

        static int k = 0;

        public static void MergeIntervals()
        {
            while (true)
            {
                Console.WriteLine("Enter starting range: ");
                int start = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter ending range: ");
                int end = Convert.ToInt32(Console.ReadLine());

                bool insert = true;

                for (int i = 0; i < k; i++)
                {
                    if (arr[i, 0] <= start && arr[i, 1] >= start || start <= arr[i, 0] && end >= arr[i, 0])
                    {
                        arr[i, 0] = Math.Min(arr[i, 0], start);
                        arr[i, 1] = Math.Max(arr[i, 1], end);
                        insert = false;
                        break;
                    }
                    else if (arr[i, 0] <= end && arr[i, 1] >= end || start <= arr[i, 1] && end >= arr[i, 1])
                    {
                        arr[i, 0] = Math.Min(arr[i, 0], start);
                        arr[i, 1] = Math.Max(arr[i, 1], end);
                        insert = false;
                        break;
                    }
                }

                if (insert)
                {
                    arr[k, 0] = start;
                    arr[k++, 1] = end;
                }
                Sort();
                remove();
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine(arr[i, 0] + "-" + arr[i, 1]);
                }
            }
        }

        public static void Sort()
        {
            for (int i = 0; i < k; i++)
            {
                int temp = 0;
                for (int j = i + 1; j < k; j++)
                {
                    if (arr[i, 0] > arr[j, 0])
                    {
                        temp = arr[i, 0];
                        arr[i, 0] = arr[j, 0];
                        arr[j, 0] = temp;
                        temp = arr[i, 1];
                        arr[i, 1] = arr[j, 1];
                        arr[j, 1] = temp;
                    }
                }
            }

        }

        public static void remove()
        {
            int i = 0, j = 0;
            List<List<int>> li = new List<List<int>>();

            for (i = 0; i < k; i++)
            {
                li.Add(new List<int>());
                li[i].Add(arr[i, 0]);
                li[i].Add(arr[i, 1]);
            }
            i = 0; j = 0;
            while (i < li.Count)
            {
                j = i + 1;
                while (j < li.Count)
                {
                    if (li[i][1] > li[j][0])
                    {
                        if (li[i][1] < li[j][1])
                        {
                            li[i][1] = Math.Max(li[i][1], li[j][1]);
                        }
                        li.RemoveAt(j);
                        j--;
                    }
                    j++;
                }
                i++;
            }

            for (i = 0; i < li.Count; i++)
            {
                arr[i, 0] = li[i][0];
                arr[i, 1] = li[i][1];
            }
            if (li.Count != 0)
            {
                k = li.Count;
            }
        }
        static void Main(string[] args)
        {
            MergeIntervals();
            Console.ReadKey();
        }
    }
}
