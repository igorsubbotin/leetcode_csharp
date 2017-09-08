// 279. Perfect Squares - https://leetcode.com/problems/perfect-squares
public class Solution {       
    public int NumSquares(int n) {
        var dp = new int[n + 1];
        for (var i = 0; i < dp.Length; i++) dp[i] = int.MaxValue;
        dp[0] = 0;
        for(var i = 1; i <= n; ++i) {
            var min = int.MaxValue;
            var j = 1;
            while(i - j * j >= 0) {
                min = Math.Min(min, dp[i - j * j] + 1);
                ++j;
            }
            dp[i] = min;
        }		
        return dp[n];
    }
}