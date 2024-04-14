using System;

public class Count<T>
{
    private T[] data;

    public Count(T[] array)
    {
        data = array;
    }

    public int CountSatisfying(Func<T, bool> predicate)
    {
        int count = 0;
        foreach (T item in data)
        {
            if (predicate(item))
            {
                count++;
            }
        }
        return count;
    }
}

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        int[] integers = { 1, 23, 4, 56, 78, 4, 3 };
        Count<int> counter = new Count<int>(integers);

        int primeCount = counter.CountSatisfying(IsPrime);
        int evenCount = counter.CountSatisfying(x => x % 2 == 0);

        Console.WriteLine("The number of primes is: " + primeCount);
        Console.WriteLine("The number of even numbers is: " + evenCount);
    }
}
