// 338. Counting Bits - https://leetcode.com/problems/counting-bits
public class Solution {
    public int[] CountBits(int num) {
        var dp = new List<int>();
        dp.Add(0);
        var i = 1;
        while (i <= num) {
            dp.Add(1);
            for (var j = 1; j < i; j++) dp.Add(dp[j] + 1);
            i *= 2;
        }
        return dp.Take(num + 1).ToArray();
    }
}