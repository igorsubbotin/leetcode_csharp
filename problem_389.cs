// 389. Find the Difference - https://leetcode.com/problems/find-the-difference
public class Solution {
    public char FindTheDifference(string s, string t) {
        var c1 = GetChars(s);
        var c2 = GetChars(t);
        for (var i = 0; i < 26; i++) {
            if (Math.Abs(c1[i] - c2[i]) != 0) return (char)(i + 97);
        }
        return (char)0;
    }
    
    private static int[] GetChars(string s) {
        var chars = new int[26];
        foreach (var c in s) chars[(int)c - 97] += 1;
        return chars;
    }
}