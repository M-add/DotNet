using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evalution2
{
    class Program
    {
        public static int[,] rotate(int[,] arr, int m, int n, int angle)
        {
            int x = m;
            int y = n;

            if (m != n)
            {
                x = n;
                y = m;
            }

            int[,] res = new int[x, y];
            int[] col = new int[n];

            int k = m - 1;

            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    //res[i, j] = arr[k, i];
                    //k--;
                    col[j] = arr[k, j];
                }
                k--;
                for (int l = 0; l < x; l++)
                {
                    res[l, i] = col[l];
                }
            }

            if (angle == 90)
            {
                Console.WriteLine("Rotated:");
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(res[i, j] + " ");
                    }
                    Console.Write("\n");
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Row:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of column:");
            int n = int.Parse(Console.ReadLine());
           

            int[,] arr = new int[m, n];
            Console.WriteLine("Enter elements:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        arr[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Please enter valid data");
                        j--;
                    }
                }

            }


            Console.WriteLine("Orginal:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

            while (true)
            {
                Console.WriteLine("Enter angle of rotation:");
                int x = int.Parse(Console.ReadLine()) % 360;

                if(x % 90 != 0)
                {
                    Console.WriteLine("Enter valid angle");
                    continue;
                }

                
                while (x > 0)
                {
                    arr = rotate(arr, m, n, x);
                    if (m != n)
                    {
                        int temp = m;
                        m = n;
                        n = temp;
                    }
                    x = x - 90;
                }

                Console.WriteLine("Enter q to quit y to continue");
                string s = Console.ReadLine();
                if(s[0] == 'q')
                {
                    break;
                }
                
            }
            



            Console.ReadKey();
        }
    }
}
