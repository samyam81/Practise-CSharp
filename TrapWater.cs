using System;

namespace kobbie
{
    class TrapWater
    {
        static void Main()
        {
            int[] arr = {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];
            int[] value = new int[arr.Length];
            
            left[0] = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                left[i] = Math.Max(left[i - 1], arr[i]);
            }
            
            right[arr.Length - 1] = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                right[i] = Math.Max(right[i + 1], arr[i]);
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                value[i] = Math.Min(right[i], left[i]) - arr[i];
            }
            
            int totalWater = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                totalWater += value[i];
            }
            
            Console.WriteLine("Total trapped water: " + totalWater);
        }
    }
}
