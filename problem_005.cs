// Longest Palindromic Substring - https://leetcode.com/problems/longest-palindromic-substring
public class Solution {
    public string LongestPalindrome(string s) {
        var result = new [] {0, 0, 0};
        for (var i = 0; i < s.Length; i++) {
            result = GetMax(result, GetPalindrome(s, i, i));
            result = GetMax(result, GetPalindrome(s, i, i + 1));
        }
        return s.Substring(result[1], result[0]);
    }
    public static int[] GetPalindrome(string s, int left, int right) {
        var result = new [] {0 ,0, 0};
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            result = new [] {right - left + 1, left, right};
            left--;
            right++;
        }
        return result;
    }
    public static int[] GetMax(int[] a, int[] b) {
        if (a[0] >= b[0]) return a;
        return b;
    }
}