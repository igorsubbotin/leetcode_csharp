// 643. Maximum Average Subarray I - https://leetcode.com/problems/maximum-average-subarray-i
public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double sum = 0.0;
        for (var i = 0; i < k; i++) sum += nums[i];
        double max = sum;
        for (var j = k; j < nums.Length; j++) {
            sum = sum - nums[j - k] + nums[j];
            max = Math.Max(max, sum);
        }
        return max / k;
    }
}