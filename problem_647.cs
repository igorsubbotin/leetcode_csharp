// 647. Palindromic Substrings - https://leetcode.com/problems/palindromic-substrings
public class Solution {
    private bool?[,] dp;
    
    public int CountSubstrings(string s) {
        dp = new bool?[s.Length, s.Length];
        var result = 0;
        for (var i = 0; i < s.Length; i++)
            for (var j = i; j < s.Length; j++)
                if (IsPalindrome(s, i, j)) result++;
        return result;
    }
    
    private bool IsPalindrome(string s, int left, int right) {
        if (dp[left, right] == null) {
            var length = right - left + 1;
            dp[left, right] = true;
            if (length > 1) dp[left, right] = (s[left] == s[left + length - 1]) && IsPalindrome(s, left + 1, right - 1);
        }
        return dp[left, right].Value;
    }
}