using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newclass
{
    class Class1
    {
        public static void swapcount()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> arr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr.Add(num);
            }
            int count;


            int result1 = 0, result2 = 0;


            List<int> orginal = new List<int>(arr);
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                dict[arr[i]] = i;
            }

            List<int> sort = new List<int>(arr);
            sort.Sort();

            for (int i = 0; i < n; i++)
            {
                if (arr[i] != sort[i])
                {
                    int current = sort[i];
                    int s = arr[i];

                    int temp = arr[dict[current]];
                    arr[dict[current]] = arr[dict[s]];
                    arr[dict[s]] = temp;

                    temp = dict[current];
                    dict[current] = dict[s];
                    dict[s] = temp;

                    result1++;
                }
            }

            //foreach(var i in dict)
            //{
            //    Console.Write(i.Value + " ");
            //}

            dict.Clear();
            for (int i = 0; i < n; i++)
            {
                dict[orginal[i]] = i;
            }
            sort.Reverse();

            for (int i = 0; i < n; i++)
            {
                if (orginal[i] != sort[i])
                {
                    int current = sort[i];
                    int s = orginal[i];

                    int temp = orginal[dict[current]];
                    orginal[dict[current]] = orginal[dict[s]];
                    orginal[dict[s]] = temp;

                    temp = dict[current];
                    dict[current] = dict[s];
                    dict[s] = temp;

                    result2++;
                }
            }
            count = Math.Min(result1, result2);
            Console.WriteLine($"The minimum number of swap needed is => {count}");
        }

        public static void matrix()
        {
            Console.WriteLine("Enter the size:");
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            Console.WriteLine("Enter the elements of the Matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
            ////matrix transpose
            //Console.WriteLine("Matrix Transpose:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i+1; j < n; j++)
            //    {
            //        int temp = arr[i, j];
            //        arr[i, j] = arr[j, i];
            //        arr[j, i] = temp;
            //    }
            //}
            ////display
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //matrix rotation
            Console.WriteLine("Matrix Rotate:");
            for (int i = 0; i < n/2; i++)
            {
                int end = n - 1;
                int l = n - 1;
                for (int j = 0; j <= n/2; j++)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[l,i];
                    arr[l, j] = arr[end,l];
                    arr[end, l] = arr[l, end];
                    arr[j, end] = temp;
                }
            }  
            //display
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
