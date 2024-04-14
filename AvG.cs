using System;

public class AvG<T>
{
    public AvG(T[] array)
    {
        double sum = 0.0;
        foreach (T item in array)
        {
            sum += Convert.ToDouble(item);
        }
        double average = sum / array.Length;
        Console.WriteLine("The Average: " + average);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        AvG<int> avgInt = new AvG<int>(integers);

        double[] doubles = { 2.2, 3.3, 4.4, 5.5, 6.6 };
        AvG<double> avgDouble = new AvG<double>(doubles);
    }
}
