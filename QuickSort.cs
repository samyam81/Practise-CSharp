using System;

namespace QuickSort
{
    class Quick
    {
        static void Main()
        {
            int[] arr = new int[50];
            Cin(arr);
            Console.WriteLine("The array is:");
            Cout(arr);
            SortQuick(arr, 0, 49);
            Console.WriteLine("The array after sorting is:");
            Cout(arr);
        }

        static void SortQuick(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                SortQuick(arr, low, pi - 1);
                SortQuick(arr, pi + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }

        static void Swap(int[] arr, int a, int b)
        {
            int temp1 = arr[a];
            arr[a] = arr[b];
            arr[b] = temp1;
        }

        static void Cin(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                arr[i] = rand.Next(1000);
            }
        }

        static void Cout(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
