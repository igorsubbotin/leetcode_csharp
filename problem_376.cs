// 376. Wiggle Subsequence - https://leetcode.com/problems/wiggle-subsequence
public class Solution {
    public int WiggleMaxLength(int[] nums) {
        if (nums.Length == 0) return 0;
        var dp = new int[nums.Length, 2];
        var max = 1;
        dp[nums.Length - 1, 0] = 1;
        dp[nums.Length - 1, 1] = 1;
        for (var i = nums.Length - 1; i >= 0; i--) {
            var j = i + 1;
            while (j < nums.Length && nums[i] > nums[j]) { 
                dp[i, 1] = Math.Max(dp[i, 1], dp[j, 0] + 1);
                j++;
            }
            j = i + 1;
            while (j < nums.Length && nums[i] < nums[j]) {
                dp[i, 0] = Math.Max(dp[i, 0], dp[j, 1] + 1);
                j++;
            }
            max = Math.Max(max, Math.Max(dp[i, 0], dp[i, 1]));
        }
        return max;
    }
}