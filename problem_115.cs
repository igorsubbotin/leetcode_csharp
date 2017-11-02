// 115. Distinct Subsequences - https://leetcode.com/problems/distinct-subsequences
public class Solution {
    public int NumDistinct(string s, string t) {
        var dp = new int[s.Length + 1, t.Length + 1];
        for (var i = 0; i <= s.Length; i++) dp[i, t.Length] = 1;
        for (var i = t.Length - 1; i >= 0; i--) {
            for (var j = s.Length - 1; j >= 0; j--) {
                dp[j, i] = dp[j + 1, i];
                if (s[j] == t[i]) dp[j, i] += dp[j + 1, i + 1];
            }
        }
        return dp[0, 0];
    }
}