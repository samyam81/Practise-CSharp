using System;
using System.Collections.Generic;

public class ThreeSumSolution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        
        for (int i = 0; i < nums.Length - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            
            int target = -nums[i];
            int left = i + 1;
            int right = nums.Length - 1;
            
            while (left < right) {
                int sum = nums[left] + nums[right];
                if (sum == target) {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    
                    left++;
                    right--;
                } else if (sum < target) {
                    left++;
                } else {
                    right--;
                }
            }
        }
        
        return result;
    }

    public static void Main(string[] args) {
        ThreeSumSolution solution = new ThreeSumSolution();
        int[] nums = { -1, 0, 1, 2, -1, -4 };
        IList<IList<int>> result = solution.ThreeSum(nums);
        foreach (var list in result) {
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
