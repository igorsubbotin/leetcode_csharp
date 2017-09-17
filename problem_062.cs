// 62. Unique Paths - https://leetcode.com/problems/unique-paths
public class Solution {
    public int UniquePaths(int m, int n) {
        var dp = new int[m, n];
        dp[m - 1, n - 1] = 1;
        for (var i = m - 1; i >= 0; i--) {
            for (var j = n - 1; j >= 0; j--) {
                if (i - 1 >= 0) dp[i - 1, j] += dp[i, j];
                if (j - 1 >= 0) dp[i, j - 1] += dp[i, j];
            }
        }
        return dp[0, 0];
    }
}