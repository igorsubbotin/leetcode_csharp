// 680. Valid Palindrome II - https://leetcode.com/problems/valid-palindrome-ii
public class Solution {
    public bool ValidPalindrome(string s) {
        var left = -1;
        var right = s.Length;
        while (++left < --right) {
            if (s[left] != s[right]) return IsValid(s, left, right + 1) || IsValid(s, left - 1, right);
        }
        return true;
    }
    
    private static bool IsValid(string s, int left, int right) {
        while (++left < --right) {
            if (s[left] != s[right]) return false;
        }
        return true;
    }
}