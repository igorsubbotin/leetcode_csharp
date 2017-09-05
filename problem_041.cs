// 41. First Missing Positive - https://leetcode.com/problems/first-missing-positive
public class Solution {
    public int FirstMissingPositive(int[] nums) {
        if (FindMinPositive(nums) != 1) return 1;
        for (var i = 0; i < nums.Length; i++) 
            if (nums[i] < 0) nums[i] = 0;
        for (var i = 0; i < nums.Length; i++) {
            var value = nums[i];
            if (value <= 0) continue;
            nums[i] = 0;
            while (value > 0) {
                var ix = value - 1;
                if (ix >= nums.Length) break;
                value = nums[ix];
                nums[ix] = -1;
            }
        }
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) return i + 1;
        }
        return nums.Length + 1;
    }
    
    private static int FindMinPositive(int[] nums) {
        var min = int.MaxValue;
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] <= 0) continue;
            min = Math.Min(min, nums[i]);
        }
        return min;
    }
}