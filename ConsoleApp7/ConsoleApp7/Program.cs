using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void print_unique()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            HashSet<int> unique = new HashSet<int>(arr);

            foreach(int i in unique)
            {
                Console.WriteLine(i);
            }
        }

        static void merge_two_arrays()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            List<int> merge = new List<int>();
            merge.AddRange(arr);
            merge.AddRange(arr1);
            merge.Sort();

            foreach(int i in merge)
            {
                Console.Write(i + " ");
            }

        }
        static void descending()
        {
            int n = int.Parse(Console.ReadLine());
            int[] e = new int[n];

            for (int i = 0; i < n; i++)
            {
                e[i] = int.Parse(Console.ReadLine());
            }

            List<int> arr = new List<int>(e);

            arr.Sort((a, b) => b.CompareTo(a));

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //print_unique();

            // merge_two_arrays();

            //descending();

            Console.WriteLine("Enter the size of the row");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the size the column");
            int m = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, m];
            Console.WriteLine("Enter the element of arry");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the size of sub array (Row and Column)");
            int sizer = int.Parse(Console.ReadLine());
            int sizec = int.Parse(Console.ReadLine());

            int max = 0, max_row = 0, max_col = 0;
            int min = 10000, min_row = 0, min_col = 0;

            int r = 0 , c = 0;
            while (r < (n - sizer)+1) 
            {
                c = 0;
                while (c < (m - sizec)+1)
                {
                    int sum = 0;
                    for (int i = r; i < r + sizer; i++)
                    {
                        for (int j = c; j < c + sizec; j++)
                        {
                            sum += arr[i, j];
                        }
                    }
                    if(sum > max)
                    {
                        max = sum;
                        max_row = r;
                        max_col = c;
                    }

                    if(sum<min)
                    {
                        min = sum;
                        min_col = c;
                        min_row = r;
                    }
                    c++;
                }
                r++;    
            }


            Console.Write("Maximum subarray: ");
            Console.WriteLine(max);
            for (int i = max_row; i < max_row + sizer; i++)
            {
                for (int j = max_col; j < max_col + sizec; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.Write("\n");
            }


            Console.Write("Minimum sub array: ");
            Console.WriteLine(min);
            for (int i = min_row; i < min_row + sizer; i++)
            {
                for (int j = min_col; j < min_col + sizec; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}
