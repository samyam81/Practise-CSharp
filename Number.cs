using System;
using System.Collections.Generic;
using System.Linq;

public class Number
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 9, 1, 2, 43, 5, -234, 23, 6, 7, 19 };

        FilterNumbers(numbers, IsPositive);
        FilterNumbers(numbers, IsDivisibleBy3);
    }

    public static void FilterNumbers(List<int> numbers, Func<int, bool> filter)
    {
        List<int> filteredNumbers = numbers.Where(filter).ToList();
        Console.WriteLine(string.Join(", ", filteredNumbers));
    }

    public static bool IsPositive(int number)
    {
        return number > 0;
    }

    public static bool IsDivisibleBy3(int number)
    {
        return number % 3 == 0;
    }
}
