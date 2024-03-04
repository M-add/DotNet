// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Collections;

public class HelloWorld
{
    public static IList<IList<int>> PermuteUnique(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums); // Sort the array to handle duplicates
        SortedSet<List<int>> set = new SortedSet<List<int>>();
        Perm(nums, 0, new List<int>(), result, set);

        //Console.WriteLine (set.Count);
        foreach (var i in set)
        {
            foreach (var j in i)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine("\n");
        }
        return result;
    }

    private static void Perm(int[] nums, int start, List<int> currentPermutation, IList<IList<int>> result, SortedSet<List<int>> set)
    {
        if (start == nums.Length-1)
        {
            if (set.Add(new List<int>(currentPermutation)))
            {
                result.Add(new List<int>(currentPermutation));
            }
            return;
        }

        for (int i = start; i < nums.Length; i++)
        {
            // Skip duplicates
            if (i > start && nums[i] == nums[i - 1])
                continue;

            currentPermutation.Add(nums[i]);
            Swap(nums, start, i);
            Perm(nums, start + 1, currentPermutation, result, set);
            Swap(nums, start, i);
            currentPermutation.RemoveAt(currentPermutation.Count - 1);
        }
    }

    private static void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    public static void Main(string[] args)
    {
        //int[] arr = { 0, 1, 0, 0, 9 };
        //IList<IList<int>> result = PermuteUnique(arr);
        //Console.WriteLine (result.Count);
        //   foreach(var i in result)
        //   {
        //       foreach(var j in i)
        //       {
        //           Console.Write(j + " ");
        //       }
        //       Console.WriteLine ("\n");
        //   }

        //combination();
        int[] nums1 = {1,2,3,0 , 0 ,0};
        int[] nums2 = { 2, 5, 6 };
       
        //Merge(nums1, 3, nums2, 3);
        

        Console.ReadKey();
    }

    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else
            {
                nums1[k--] = nums2[j--];
            }
        }

        while (j >= 0)
        {
            nums1[k--] = nums2[j--];
        }
    }

    public static void combination()
    {
        List<int> list = new List<int> { 1, 2, 3, 4 };
        List<List<int>> result = new List<List<int>>();

        comb(list, 0, 2, new List<int>(), result);

        foreach(var i in result)
        {
            foreach(var j in i)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
    public static void comb(List<int> list, int start, int k, List<int> current, List<List<int>> result)
    {
        if (current.Count == k)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = start; i < list.Count; i++)
        {
            if (current.Count < k)
            {
                current.Add(list[i]);
                comb(list, i + 1, k, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}