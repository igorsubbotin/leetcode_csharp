// 76. Minimum Window Substring - https://leetcode.com/problems/minimum-window-substring
public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length) return string.Empty;
        var hash = new int[256];
        foreach (var c in t) hash[c]++;
        int? min = null;
        var min_left = 0;
        var min_right = 0;
        var left = 0;
        var right = 0;
        var count = t.Length;
        var found = false;
        while (right < s.Length) {
            if (--hash[s[right]] >= 0) count--;
            while (count == 0) {
                var length = right - left + 1;
                if (min == null || length < min) {
                    min = length;
                    min_left = left;
                    min_right = right;
                }
                if (++hash[s[left++]] > 0) count++;
            }
            right++;
        }
        if (min == null) return string.Empty;
        return s.Substring(min_left, min_right - min_left + 1);
    }
}