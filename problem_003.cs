// Longest Substring Without Repeating Characters - https://leetcode.com/problems/longest-substring-without-repeating-characters
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var max = 0;
        var d = new Dictionary<int, int>();
        var j = 0;
        var i = 0;
        while (i < s.Length) {
            var c = GetCharCode(s[i]);
            if (d.ContainsKey(c)) {
                max = Math.Max(max, i - j);
                var top = d[c];
                for (var k = j; k <= top; k++) {
                    d.Remove(GetCharCode(s[k]));
                }
                j = top + 1;
            }
            d.Add(c, i);
            i += 1;
        }
        return Math.Max(max, i - j);
    }
    
    private static int GetCharCode(char c) {
        return (int)c - 97;
    }
}