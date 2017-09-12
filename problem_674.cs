// 674. Longest Continuous Increasing Subsequence - https://leetcode.com/problems/longest-continuous-increasing-subsequence
public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        if (nums.Length == 0) return 0;
        var length = 1;
        var max = 1;
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i - 1] >= nums[i])length = 0;
            length++;
            max = Math.Max(max, length);
        }
        return max;
    }
}