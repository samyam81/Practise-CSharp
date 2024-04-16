using System;

public class LongestPalindrome
{
    public static void Main(string[] args)
    {
        string[] str = { "abc", "car", "ada", "racecar", "cool" };
        string result = Check(str);
        Console.WriteLine(result);
    }

    private static string Check(string[] str)
    {
        string temp = "";
        foreach (string word in str)
        {
            if (IsPalindrome(word))
            {
                if (word.Length > temp.Length)
                {
                    temp = word;
                }
            }
        }
        return temp;
    }

    private static bool IsPalindrome(string str)
    {
        int start = 0;
        int end = str.Length - 1;
        while (start < end)
        {
            if (str[start] != str[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
