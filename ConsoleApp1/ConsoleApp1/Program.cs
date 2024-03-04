using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace sample
{
    class sample
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2*i-1; j++)
                {
                    if (j == 1 || j == 2 * i - 1) 
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++) 
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if (j == 1 || j == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}