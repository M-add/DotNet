using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_layer__rotation
{
    class Program
    {
        public static void matrixRotation(List<List<int>> mat, int r)
        {
            int n = mat.Count;
            int m = mat[0].Count;

            while (r > 0)
            {
                int layer = Math.Min(n, m) / 2;
                int sr = 0, er = n - 1;
                int sc = 0, ec = m - 1;

                List<List<int>> rot = new List<List<int>>();
                for (int i = 0; i < n; i++)
                {
                    rot.Add(new List<int>());
                    for (int j = 0; j < m; j++)
                    {
                        rot[i].Add(0);
                    }
                }
                while (layer > 0)
                {
                    for (int i = sc; i <= ec - 1; i++)
                    {
                        rot[sr][i] = mat[sr][i + 1];
                    }
                    for (int i = sr + 1; i <= er; i++)
                    {
                        rot[i][sc] = mat[i - 1][sc];
                    }
                    for (int i = sr + 1; i <= ec; i++)
                    {
                        rot[er][i] = mat[er][i - 1];
                    }
                    for (int i = er - 1; i >= sr; i--)
                    {
                        rot[i][ec] = mat[i + 1][ec];
                    }

                    sc++;
                    sr++;
                    er--;
                    ec--;
                    layer--;
                }
                mat.Clear();
                mat.AddRange(rot);
                r--;
            }
        }
        static void Main(string[] args)
        {
            int m = 4;
            int n = 4;
            int r = 2;

            List<List<int>> matrix = new List<List<int>>()
            {
            new List<int> {1, 2, 3, 4},
            new List<int> {5, 6, 7, 8},
            new List<int> {9, 10, 11, 12},
            new List<int> {13, 14, 15, 16}
            };

            matrixRotation(matrix, r);

            // Print the rotated matrix
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            Console.ReadKey();
        }
    }
}
