using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using problem1;
using System;


public class HelloWorld
{
    

    public static void Main(string[] args)
    {
        //problems.problem1();
        //problems.grid();
        int[][] grid = new int[5][]{
            new int[] {-73,61,43,-48,-36},
            new int[] {3,30,27,57,10},
            new int[] {96,-76,84,59,-15},
            new int[] {5,-49,76,31,-7},
            new int[] {97,91,61,-46,67}
        };

        
        int result = int.MaxValue;

        int n = grid.Length;
        int m = grid[0].Length;

        int[,] dp = new int[n, m];

        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < m; j++)
            {
                if(i == 0)
                {
                    dp[i, j] = grid[i][j];
                }
                else
                {
                    int temp = grid[i][j];
                    int min = int.MaxValue;
                    for (int k = 0 ; k < n; k++)
                    {
                        if(k != j)
                        {
                            min = Math.Min(min, temp + dp[i-1,k]);
                        }
                    }
                    dp[i, j] = min;
                }
                if(i == n-1)
                {
                    result = Math.Min(result, dp[n - 1, j]);
                }
            }
        }

        Console.WriteLine(result);

        int c = 1;
        foreach (var i in dp)
        {
            Console.Write(i + " ");
            if (c++ / grid[0].Length == 1)
            {
                c = 1;
                Console.WriteLine();
            }
        }

        Console.ReadKey();
    }
}
