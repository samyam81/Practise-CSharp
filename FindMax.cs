using System;
using System.Linq;

namespace Samyam
{
    class max
    {
        static void Main()
        {
            int[] array = { 4, 5, 6, 7, 99, 8, 12, 34, 53 };
            int result = FindMax(array);
            Console.WriteLine("The max element in the array is: " + result);
        }

        static int FindMax(int[] array)
        {
            return array.Max();
        }
    }
}
