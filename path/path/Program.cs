using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace path
{
    class Program
    {
        static int number_of_paths(int n, int m, int[,] arr)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if(arr[i,j] != -1)
                    {
                        if (arr[i - 1, j] == -1 || arr[i, j - 1] == -1)
                        {
                            arr[i, j] = Math.Max(arr[i - 1, j], arr[i, j - 1]);
                        }
                        else
                        {
                            arr[i, j] = arr[i - 1, j] + arr[i, j - 1];
                        }
                    }
 
                }
            }

            return arr[n - 1, m - 1];
        }
        static bool possible_path(int n, int m, int[,] arr)
        {
            arr[0, 0] = 1; //starting node

            for (int i = 1; i < m; i++)
            {
                if (arr[0, i] != -1) 
                {
                    arr[0, i] = arr[0, i - 1];
                }
            }
            for (int j = 1; j < n; j++)
            {
                if (arr[j, 0] != -1) 
                {
                    arr[j, 0] = arr[j - 1, 0];
                }
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (arr[i, j] != -1)
                    {
                        arr[i, j] = Math.Max(arr[i - 1, j], arr[i, j - 1]);
                    }
                }

                if(arr[n-1,m-1] == 1)
                {
                    return true;
                }
            }

            return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Row:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the size of Column:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the array elements:");
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            if (possible_path(n, m, arr))
            {
                Console.WriteLine("Yes,there exists a path from top to bottom");
            }
            else
            {
                Console.WriteLine("No path exists");
            }

            //to calculate number of paths
            if (possible_path(n, m, arr))
            {
                Console.WriteLine(number_of_paths(n, m, arr));
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.ReadKey();
        }
    }
}
