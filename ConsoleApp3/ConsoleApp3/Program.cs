using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string longestSubstring = FindLongestNonRepeatingSubstring(input);

        Console.WriteLine($"Longest Non-Repeating Substring: {longestSubstring}");

        Console.ReadKey();
    }

    static string FindLongestNonRepeatingSubstring(string s)
    {
        int maxLength = 0; // Length of the longest non-repeating substring
        int start = 0;     // Starting index of the current substring
        int maxStart = 0;  // Starting index of the longest non-repeating substring

        Dictionary<char, int> lastIndex = new Dictionary<char, int>();

        for (int end = 0; end < s.Length; end++)
        {
            if (lastIndex.ContainsKey(s[end]) && lastIndex[s[end]] >= start)
            {
                // Move the start index to the right of the last occurrence of s[end]
                start = lastIndex[s[end]] + 1;
            }

            lastIndex[s[end]] = end; // Update the last index of s[end]

            if (end - start + 1 > maxLength)
            {
                maxLength = end - start + 1;
                maxStart = start;
            }
        }
        Console.WriteLine(lastIndex[s[0]]);
        return s.Substring(maxStart, maxLength);
    }
}
