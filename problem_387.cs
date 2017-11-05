// 387. First Unique Character in a String - https://leetcode.com/problems/first-unique-character-in-a-string
public class Solution {
    public int FirstUniqChar(string s) {
        var hash = new int[256];
        foreach (var c in s) hash[c]++;
        for (var i = 0; i < s.Length; i++) {
            if (hash[s[i]] == 1) return i;
        }
        return -1;
    }
}