// 494. Target Sum - https://leetcode.com/problems/target-sum/
public class Solution {
    public int FindTargetSumWays(int[] nums, int S) {
        if (nums.Length == 0) return 0;
        var dp = new Dictionary<int, int>[nums.Length];
        for (var i = 0; i < nums.Length; i++) dp[i] = new Dictionary<int, int>();
        Add(dp, nums.Length - 1, nums[nums.Length - 1], 1);
        Add(dp, nums.Length - 1, -nums[nums.Length - 1], 1);
        for (var i = nums.Length - 2; i >= 0; i--) {
            foreach (var pair in dp[i + 1]) {
                Add(dp, i, pair.Key + nums[i], pair.Value);
                Add(dp, i, pair.Key - nums[i], pair.Value);
            }
        }
        var result = 0;
        foreach (var pair in dp[0])
            if (pair.Key == S) result += pair.Value;
        return result;
    }
    
    private static void Add(Dictionary<int, int>[] dp, int ix, int num, int count) {
        if (!dp[ix].ContainsKey(num)) dp[ix][num] = 0;
        dp[ix][num] += count;
    }
}