using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public static void three_dimension()
        {
            // Declare a 3-dimensional array with dimensions 2x3x4
            int[,,] threeDimensionalArray = new int[2, 3, 4];

            // Initialize the array with values
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        threeDimensionalArray[i, j, k] = i * 100 + j * 10 + k;
                    }
                }
            }

            // Access and print values from the array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine($"Element at [{i}, {j}, {k}] = {threeDimensionalArray[i, j, k]}");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");
            }

        }

        public static void two_dimension()
        {
            // Declare and initialize a 2D array with dimensions 3x4
            int[,] twoDimensionalArray = new int[3, 4];

            // Initialize the array with values
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    twoDimensionalArray[row, col] = row * 10 + col;
                }
            }

            // Access and print values from the array
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.WriteLine($"Element at [{row}, {col}] = {twoDimensionalArray[row, col]}");
                }
            }

        }
        static void Main(string[] args)
        {
            //datetime d = datetime.now;
            //string s = d.tostring();

            //console.write(s.length);

            List<int> numbers = new List<int>{ 6, 7, 1, 3, 5 };

            var res = from n in numbers orderby n ascending select n ;

            //foreach(var i in res)
            //{
            //    Console.WriteLine(i);
            //}


            //Program.three_dimension();
            Program.two_dimension();

            Console.ReadKey();
        }
    }
}
