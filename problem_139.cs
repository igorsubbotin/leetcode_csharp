// 139. Word Break - https://leetcode.com/problems/word-break
public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var hs = new HashSet<string>(wordDict);
        var m = new bool[s.Length, s.Length];
        for (var i = 0; i < s.Length; i++)
            for (var j = i; j < s.Length; j++)
                m[i, j] = hs.Contains(s.Substring(i, j - i + 1));
        var dp = new bool[s.Length + 1];
        dp[s.Length] = true;
        for (var i = s.Length - 1; i >= 0; i--)
            for (var j = i; j < s.Length && !dp[i]; j++)
                if (m[i, j] && dp[j + 1]) dp[i] = true;
        return dp[0];
    }
}