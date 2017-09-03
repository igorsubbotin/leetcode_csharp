// 53. Maximum Subarray - https://leetcode.com/problems/maximum-subarray
public class Solution {
    public int MaxSubArray(int[] nums) {
        var max = int.MinValue;
        var sum = 0;
        for (var i = 0; i < nums.Length; i++) {
            max = Math.Max(max, nums[i]);
            sum += nums[i];
            max = Math.Max(max, sum);
            if (sum < 0) sum = 0;
        }
        return max;
    }
}