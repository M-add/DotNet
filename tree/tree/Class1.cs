using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree1
{
    class node
    {
        public int value { get; set; }
        public List<node> children { get; set; }

        public node()
        {
            value = 0;
            children = new List<node>();
        }
    }
    class tree
    {
        private node[] nodes;

        public tree(int n)
        {
            nodes = new node[n + 1];
            for (int i = 1; i <= n; i++)
            {
                nodes[i] = new node();
            }
        }

        public void addedge(int x, int y)
        {
            nodes[x].children.Add(nodes[y]);
        }

        public void addvalue(int t , int v)
        {
            nodes[t].value += v;
        }

        private int dfs(node node, int max)
        {
            max = Math.Max(max, node.value);
            foreach (node child in node.children)
            {
                max = dfs(child, max);
            }
            return max;
        }

        public int maxvalue(int a, int b)
        {
            int max = 0;

            while (a != b)
            {
                max = Math.Max(max, nodes[a].value);
                max = Math.Max(max, nodes[b].value);
                a = Math.Min(a, b) / 2;
                b = Math.Max(a, b) / 2;
            }

            return max;
        }

    }
    class Class1
    {
        public static void maintree()
        {
            int n = int.Parse(Console.ReadLine());

            tree tr = new tree(n);
            for (int i = 1; i < n; i++)
            {
                string[] edge = Console.ReadLine().Split();
                int x = Convert.ToInt32(edge[0]);
                int y = Convert.ToInt32(edge[1]);

                tr.addedge(x, y);
            }
            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                string[] query = Console.ReadLine().Split();
               
                if (query[0] == "add")
                {
                    int t = Convert.ToInt32(query[1]);
                    int v = Convert.ToInt32(query[2]);
                    tr.addvalue(t, v);
                }
                else if (query[0] == "max")
                {
                    int a = Convert.ToInt32(query[1]);
                    int b = Convert.ToInt32(query[2]);
                    int max = tr.maxvalue(a, b);
                    Console.WriteLine( max);
                }
            }
        }
    }
}
