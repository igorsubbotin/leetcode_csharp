// 28. Implement strStr() - https://leetcode.com/problems/implement-strstr
public class Solution {
    public int StrStr(string haystack, string needle) {
        if (string.IsNullOrEmpty(needle)) return 0;
        var i = 0;
        var j = 0;
        while (i < haystack.Length) {
            if (haystack[i] == needle[j]) {
                j++;
            }
            else {
                i = i - j;
                j = 0;
            }
            i++;
            if (j == needle.Length) return i - j;
        }
        return -1;
    }
}