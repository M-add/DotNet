using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LucidLibrary;

namespace train
{
    public static class bass
    {

        public static void Q1()
        {
            Console.WriteLine("Enter Your Name");

            string s = Console.ReadLine();
            Console.WriteLine("Hello" + " " + s);
        }

        public static void Q2()
        {
            Console.WriteLine("Enter two numbers:");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition of two numbers:" + (n + m));
        }

        public static void Q3()
        {
            Console.WriteLine("Enter two numbers:");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("division:" + (n / m));
        }

        public static void Q4()
        {
            Console.WriteLine("-1 + 4 * 6");
            Console.WriteLine("( 35+ 5 ) % 7");
            Console.WriteLine("14 + -4 * 6 / 11");
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2");
        }
        public static void Q5()
        {
            Console.WriteLine("Enter two numbers:");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int temp = n;
            n = m;
            m = temp;

            Console.WriteLine($"After Swapping n={n},m={m}");
        }

        public static void Q6()
        {
            Console.WriteLine("Enter three numbers:");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());

            Console.WriteLine(n * m * o);
        }

        public static void Q7()
        {
            Console.WriteLine("Enter two numbers:");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition:" + (n + m));
            Console.WriteLine("Subtraction:" + (n - m));
            Console.WriteLine("Multiplication:" + n * m);
            Console.WriteLine("Divison:" + n / m);
            Console.WriteLine("Mod:" + n % m);
        }

        public static void Q8()
        {
            Console.WriteLine("Enter a numbers:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }
        public static void Q9()
        {
            Console.WriteLine("Enter 4 numbers:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine($"Average of {a} {b} {c} {d} is: {(a + b + c + d) / 4}");
        }
        public static void Q10()
        {
            Console.WriteLine("Enter three numbers:");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());

            Console.WriteLine((n + m) * o);
            Console.WriteLine((n * m) + (m * o));
        }
        public static void Q11()
        {
            Console.WriteLine("Enter age:");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"You Look Older Than {a}");
        }

        public static void Q12()
        {
            Console.WriteLine("Enter a number:");

            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{a} {a} {a} {a}");
                }
                else
                {
                    Console.WriteLine(a + "" + a + "" + a + "" + a);
                }
            }
        }

        public static void Q13()
        {
            Console.WriteLine("Enter a numbers:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0 || j == 0 || i == 4 || j == 2)
                    {
                        Console.Write(n);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
        public static void Q14()
        {
            Console.WriteLine("Enter celsius:");
            int c = int.Parse(Console.ReadLine());

            int k = Convert.ToInt32(c + 273.15);
            int f = Convert.ToInt32((c * 1.8) + 32);

            Console.WriteLine("Kelvin:" + k);
            Console.WriteLine("Fahrenheit:" + f);
        }

        public static void Q15()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            Console.WriteLine("Enter a index to be removed from the string:");
            int n = int.Parse(Console.ReadLine());

            string s = str.Remove(n, n);
            Console.WriteLine("After removing:" + s);
        }

        public static void Q16()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder(str);

            sb[sb.Length - 1] = str[0];
            sb[0] = str[str.Length - 1];
            sb.ToString();

            Console.WriteLine(sb);
        }
        public static void Q17()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            Console.WriteLine(str[0] + str + str[str.Length - 1]);
        }
        public static void Q18()
        {
            Console.WriteLine("Enter two numbers:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < 0 && b > 0)
            {
                Console.WriteLine("True");
            }
            else if (a > 0 && b < 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public static void Q19()
        {
            Console.WriteLine("Enter two numbers:");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int sum = n + m;
            if (n == m)
            {
                Console.WriteLine(3 * sum);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
        public static void Q20()
        {
            Console.WriteLine("Enter two numbers:");

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int diff = Math.Abs(n - m);
            if (n > m)
            {
                Console.WriteLine(2 * diff);
            }
            else
            {
                Console.WriteLine(diff);
            }
        }

        public static void Q21()
        {
            Console.WriteLine("Enter two numbers:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            if (sum == 20 || a == 20 || b == 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public static void Q22()
        {
            Console.WriteLine("Enter a numbers:");

            int number = int.Parse(Console.ReadLine());

            bool withinRange = (Math.Abs(100 - number) <= 20) || (Math.Abs(200 - number) <= 20);

            if (withinRange)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public static void Q23()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            Console.WriteLine(str.ToLower());
        }
        public static void Q24()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');

            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine(longestWord);
        }
        public static void Q25()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Q26()
        {
            int sum = 0;
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        public static void Q27()
        {
            Console.WriteLine("Enter a numbers:");

            int n = int.Parse(Console.ReadLine());
            int sum = 0, m;
            while (n > 0)
            {
                m = n % 10;
                sum += m;
                n = n / 10;
            }

            Console.WriteLine(sum);
        }
        public static void Q28()
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            Array.Reverse(words);

            string rev = string.Join(" ", words);

            Console.WriteLine(rev);
        }
        public static void Q29()
        {
            FileInfo f = new FileInfo("C:\\boot\\macrium\\Drivers");
            Console.WriteLine(f.Length.ToString());
        }
        public static void Q30()
        {
            Console.WriteLine("Enter a numbers:");

            string hexNumber = Console.ReadLine();
            long decimalNumber = Convert.ToInt64(hexNumber, 16);

            Console.WriteLine($"Decimal equivalent: {decimalNumber}");
        }
        public static void Q31()
        {
            int n=int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] result = new int[arr1.length];

            for (int i = 0; i < arr1.length; i++)
            {
                result[i] = arr1[i] * arr2[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        public static void Q32()
        {
            Console.WriteLine("Enter a string:");

            string s = Console.ReadLine();

            if(s.Length < 4)
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine(s.);
            }
        }
    }
}
