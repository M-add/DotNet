using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static char[] arr = new char[100];
         
        public static bool check(char a)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(a == arr[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void letter_frequency()
        {
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                char temp = str[i];
                int count = 1;
                if (check(temp) && temp != ' ')
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (temp == str[j])
                        {
                            count++;
                            arr[i] = str[j];
                        }
                    }

                    Console.WriteLine(temp + "-" + count);
                }
            }
        }

        static void Main(string[] args)
        {
            //letter_frequency();

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i < n; i++)
            {
                if(arr[i] == 0 && i < n-1)
                {
                    int temp = arr[i+1];

                    for(int j = i + 2 ; j < n ; j++)
                    {
                        int temp2 = arr[j];
                        arr[j] = temp;
                        temp = temp2;
                    }

                    arr[i+1] = 0;
                    i++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
