using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    class problems
    {
        public static List<string> combinations = new List<string>();

        public static void mergeInt()
        {
            int[][] arr = new int[2][];
            arr[0] = new int[1];
            arr[1] = new int[1];
        }

        public static void permutation(string str, int l, int r)
        {
            if (l == r)
            {
                //Console.WriteLine(str);
                combinations.Add(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permutation(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }

        public static string swap(string str, int i, int j)
        {
            char[] ch = str.ToCharArray();

            char temp = ch[i];
            ch[i] = ch[j];
            ch[j] = temp;

            string s = new string(ch);

            return s;
        }
        public static void problem1()
        {

            Console.WriteLine("Enter n value: ");
            int n = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter K value: ");
            int k = int.Parse(Console.ReadLine());

            string inp = "";
            for (int i = 1; i <= n; i++)
            {
                inp += i;
            }

            permutation(inp, 0, inp.Length - 1);

            foreach(string s in combinations)
            {
                Console.Write("\""+ s +"\"" + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Combination at {0} index is:-> {1}", k, combinations[k - 1]);
        }

        public static string GridChallenge(List<string> grid)
        {
            List<List<string>> arr = new List<List<string>>();

            foreach (var s in grid)
            {
                char[] c = s.ToCharArray();
                Array.Sort(c);

                arr.Add(new List<string> { new string(c) });
            }

            for (int i = 0; i < grid.Count; i++)
            {
                //Console.WriteLine(arr[i][0].Length);
                int t = 0;
                for (int j = 0; j < arr[i][0].Length - 1; j++)
                {
                    if (arr[i][0][j] > arr[i][0][j + 1])
                    {
                        return "NO";
                    }
                    if (arr[t][0][i] > arr[t + 1][0][i])
                    {
                        return "NO";
                    }
                    if (t < grid.Count - 1)
                    {
                        t++;
                    }
                }
            }
            return "YES";
        }

        public static void grid()
        {
            int n = 3;
            List<string> grid = new List<string>
            {
               "rpb",
               "hot",
               "qra"
            };
            Console.WriteLine(GridChallenge(grid));
        }

        
    }
}
