// 518. Coin Change 2 - https://leetcode.com/problems/coin-change-2
public class Solution {
    public int Change(int amount, int[] coins) {
        var dp = new int[amount + 1];
        dp[0] = 1;
        foreach (var coin in coins)
            for (var i = coin; i < dp.Length; i++)
                dp[i] = dp[i] + dp[i - coin];
        return dp[dp.Length - 1];
    }
}