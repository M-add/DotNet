using System;

class Program
{
    static string HighestValuePalindrome(string s, int n, int k)
    {
        char[] charArray = s.ToCharArray();
        int changes = 0;

        // Calculate the number of changes needed to make s a palindrome
        for (int i = 0; i < n / 2; i++)
        {
            if (s[i] != s[n - i - 1])
            {
                changes++;
            }
        }

        // If the number of changes required exceeds the allowed maximum, it's not possible
        if (changes > k)
        {
            return "-1";
        }

        for (int i = 0; i < n / 2; i++)
        {
            int j = n - i - 1;

            if (charArray[i] != charArray[j])
            {
                char maxChar = (char)Math.Max(charArray[i], charArray[j]);
                charArray[i] = maxChar;
                charArray[j] = maxChar;
                k--; // Use one change
            }
        }

        // After making it a palindrome, if changes are left, improve the value
        for (int i = 0; i < n / 2 && k > 0; i++)
        {
            if (charArray[i] != '9')
            {
                // Use two changes to make both digits '9'
                if (k >= 2)
                {
                    charArray[i] = '9';
                    charArray[n - i - 1] = '9';
                    k -= 2;
                }
                // Use one change to make one digit '9'
                else if (k == 1)
                {
                    charArray[i] = '9';
                    charArray[n - i - 1] = '9';
                    k--;
                }
            }
        }

        // If n is odd and there is still a change left, make the middle digit '9'
        if (k > 0 && n % 2 == 1)
        {
            charArray[n / 2] = '9';
        }

        return new string(charArray);
    }

    static void Main(string[] args)
    {
        int n, k;
        string s;

        // Read input
        string[] input = Console.ReadLine().Split();
        n = int.Parse(input[0]);
        k = int.Parse(input[1]);
        s = Console.ReadLine();

        // Call the function to get the result
        string result = HighestValuePalindrome(s, n, k);

        // Output the result
        Console.WriteLine(result);

        Console.ReadKey();
    }
}

