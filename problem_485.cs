// 485. Max Consecutive Ones - https://leetcode.com/problems/max-consecutive-ones
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        if (nums.Length == 2) return nums[0] + nums[1];
        var result = 0;
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] == 0) continue;
            nums[i] += nums[i - 1];
            result = Math.Max(result, nums[i]);
        }
        return result;
    }
}