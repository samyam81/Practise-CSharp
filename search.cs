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

            int result = SequentialSearch(array, search);
            if (result == -1)
            {
                Console.WriteLine("Not present");
            }
            else
            {
                Console.WriteLine("Found at index: " + result);
            }
        }

        static int SequentialSearch(int[] array, int search)
        {
            int index = 0;
            foreach (int num in array)
            {
                if (num == search)
                    return index;
                index++;
            }
            return -1;
        }
    }
}
