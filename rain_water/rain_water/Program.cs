using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rain_water
{
    class Program
    {
        static int max = 0;
        static int min = 0;
        static int maxs, maxe, mins, mine;

        static int build(int i, int n, int[] arr)
        {
            int sum = 0;
            for (int j = i; j < n; j++)
            {
                sum += arr[j];
            }
            return sum;
        }

        static void store(int n,int[] arr)
        {
            int temp;
            for (int i = 0; i < n; i++)
            {
                int btw = (n - 1 - i) + (n - 2 - i);

                int buildings = build(i+1,n-1,arr);

                temp = Math.Abs((Math.Min(arr[i], arr[n - 1])) * btw - buildings);

                if(min==0)
                {
                    min = temp;
                }
                if(temp > max)
                {
                    max = temp;
                    maxs = i;
                    maxe = n - 1;
                }
                if (temp <= min && i!=n-1  ) 
                {
                    min = temp;
                    mins = i;
                    mine = n - 1;
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
             
            for (int i = 0; i < n; i++)
            {
                store(n - i, arr);
            }

            Console.WriteLine(max + " " + maxs + " " + maxe);
            Console.WriteLine(min + " " + mins + " " + mine);

            Console.ReadKey();
        }
    }
}
