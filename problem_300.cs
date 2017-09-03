// 300. Longest Increasing Subsequence - https://leetcode.com/problems/longest-increasing-subsequence
public class Solution {
    public int LengthOfLIS(int[] nums) {
        if (nums.Length == 0) return 0;
        var seq = new int[nums.Length];
        for (var i = nums.Length - 1; i >= 0; i--) {
            seq[i] = 1;
            for (var j = i + 1; j < nums.Length; j++) {
                if (nums[i] < nums[j]) seq[i] = Math.Max(seq[i], 1 + seq[j]);
            }
        }
        return seq.Max();
    }
}