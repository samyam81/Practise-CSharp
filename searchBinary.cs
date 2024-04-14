using System;

namespace Std
{
    class Search
    {
        static void Main()
        {
            int search;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Insert the number you want to search");
            int.TryParse(Console.ReadLine(), out search);

            int result = BinarySearch(array, search);
            if (result == -1)
            {
                Console.WriteLine("Not present");
            }
            else
            {
                Console.WriteLine("Found at index: " + (result + 1));
            }
        }

        static int BinarySearch(int[] array, int search)
        {
            int first = 0;
            int last = array.Length - 1; 
            while (first <= last)
            {
                int middle = (first + last) / 2;
                if (array[middle] == search)
                    return middle;
                else if (array[middle] < search)
                {
                    first = middle + 1;
                }
                else
                {
                    last = middle - 1;
                }
            }
            return -1;
        }
    }
}
