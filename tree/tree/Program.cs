using System;
using System.Collections.Generic;
using tree1;

class Solution
{
    //static int[] weight = new int[1000];
    static List<int>[] tree;
    static int[] values;
    static void Max(HashSet<int> node)
    {
        int max = int.MinValue;
        foreach (var i in node)
        {
            max = Math.Max(values[i], max);
        }
        Console.WriteLine("==========================================>" + max);
    }

    static HashSet<int> MaxLeft(int x, int n, int y)
    {
        var node = new HashSet<int>();
        var stack = new Stack<int>();
        stack.Push(x);

        while (stack.Count > 0)
        {
            int current = stack.Pop();
            node.Add(current);

            for(int i = 1; i < n ; i++)
            {
                if(tree[i].Contains(current) && !tree[i].Contains(y))
                {
                    stack.Push(i);
                }
                if(current == y)
                {
                    return node;
                }
            }
        }

        return node;
    }

    static HashSet<int> MaxRight(int y, int n)
    {
        var node = new HashSet<int>();
        var stack = new Stack<int>();
        stack.Push(y);

        while (stack.Count > 0)
        {
            int current = stack.Pop();
            node.Add(current);
            for (int i = 1; i < n; i++)
            {
                if(tree[i].Contains(current))
                {
                    stack.Push(i);
                }
            }
        }

        return node;
    }

    public static HashSet<int> NAdd(int x)
    {
        var n = new HashSet<int>();
        var stack = new Stack<int>();
        stack.Push(x);

        while (stack.Count > 0)
        {
            int current = stack.Pop();
            n.Add(current);

            foreach (var i in tree[current])
            {
                if (!n.Contains(i))
                {
                    stack.Push(i);
                }
            }
        }

        return n;
    }
    static void display()
    {
        foreach(int i in values)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    static void Main(String[] args)
    {
        Class1.maintree();
        int n = int.Parse(Console.ReadLine());
        values = new int[n + 1];
        tree = new List<int>[n + 1];

        for (int i = 1; i <= n; i++)
        {
            tree[i] = new List<int>();
        }

        for (int i = 1; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            if (x > y)
            {
                tree[y].Add(x);
            }
            else
            {
                tree[x].Add(y);
            }

        }
        Console.WriteLine("*****************************************************");
        //for(int i = 1; i <= n; i++)
        //{
        //    Console.Write(i +" -");
        //    foreach (int child in tree[i])
        //    {
        //        Console.Write(child  + " ");
        //    }
        //    Console.WriteLine();
        //}
        Console.WriteLine("*****************************************************");
        int q = int.Parse(Console.ReadLine());

        for (int i = 0; i < q; i++)
        {
            string[] query = Console.ReadLine().Split();
            int x = int.Parse(query[1]);
            int y = int.Parse(query[2]);

            if (query[0] == "add")
            {
                HashSet<int> na = new HashSet<int>();
                na = NAdd(x);
                foreach (var child in na)
                {
                    // Console.Write(child + " ");
                    values[child] += y;
                }
                // Console.WriteLine();
                //addweight(x, y);
                display();
            }
            if (query[0] == "max")
            {
                HashSet<int> node = MaxLeft(x, n, y);
                if (!node.Contains(y))
                {
                    node.UnionWith(MaxRight(y, n));
                }
                foreach (var item in node)
                {
                    Console.Write(item + " ");
                }
                Max(node);
            }
        }
        //while (true)
        //{
        //    Console.Beep(3276, 5000);
        //}
        Console.ReadKey();
    }
}
