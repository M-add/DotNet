using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<List<int>> ans = new List<List<int>>(n - 1);
        for (int i = 0; i < n - 1; i++)
        {
            ans.Add(new List<int>(n - 1));
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                ans[i].Add(FindDist(n, i + 1, j + 1));
            }
        }

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(string.Join(" ", ans[i]));
        }

        Console.ReadKey();
    }

    static List<Tuple<int, int>> AllMoves(int i, int j, int a, int b, int n)
    {
        List<Tuple<int, int>> moves = new List<Tuple<int, int>>();
        int[] deltaX = { a, a, -a, -a, b, b, -b, -b };
        int[] deltaY = { b, -b, b, -b, a, -a, a, -a };

        for (int k = 0; k < 8; k++)
        {
            int newX = i + deltaX[k];
            int newY = j + deltaY[k];
            if (newX >= 0 && newX < n && newY >= 0 && newY < n)
            {
                moves.Add(Tuple.Create(newX, newY));
            }
        }

        //foreach(var l in moves)
        //{
        //    Console.Write(l.Item1 +"," + l.Item2);
        //}
        //Console.WriteLine();
        return moves;
    }

    static int FindDist(int n, int a, int b)
    {
        List<List<int>> dist = new List<List<int>>(n);
        for (int i = 0; i < n; i++)
        {
            dist.Add(new List<int>(n));
            for (int j = 0; j < n; j++)
            {
                dist[i].Add(-1);
            }
        }

        dist[n - 1][n - 1] = 0;
        Queue<Tuple<int, int>> todo = new Queue<Tuple<int, int>>();
        todo.Enqueue(Tuple.Create(n - 1, n - 1));

        while (todo.Count > 0)
        {
            Tuple<int, int> current = todo.Dequeue();
            int i = current.Item1;
            int j = current.Item2;
            List<Tuple<int, int>> newMoves = AllMoves(i, j, a, b, n);

            foreach (var move in newMoves)
            {
                if (dist[move.Item1][move.Item2] == -1)
                {
                    dist[move.Item1][move.Item2] = dist[i][j] + 1;
                    todo.Enqueue(move);

                    if (move.Item1 == 0 && move.Item2 == 0)
                    {
                        break;
                    }
                }
            }
        }

        return dist[0][0];
    }
}
