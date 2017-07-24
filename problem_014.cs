// 14. Longest Common Prefix - https://leetcode.com/problems/longest-common-prefix
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var result = string.Empty;
        var i = 0;
        while (true) {
            char? c = null;
            foreach (var str in strs) {
                if (str.Length == i) return result;
                if (c == null) c = str[i];
                if (str[i] != c.Value) return result;
            }
            if (c == null) return result;
            result += c;
            i++;
        }
        return null;
    }
}