// Palindrome Number - https://leetcode.com/problems/palindrome-number
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) return false;
        var length = 0;
        var n = x;
        while (n > 0) {
            length++;
            n = n / 10;
        }
        n = x;
        for (var i = 0; i < length / 2; i++) {
            var left = x % 10;
            x /= 10;
            var p = (int)Math.Pow(10, length - i - 1);
            var right = n / p;
            n %= p;
            if (left != right) return false;
        }
        return true;
    }
}