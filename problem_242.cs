// 242. Valid Anagram - https://leetcode.com/problems/valid-anagram
public class Solution {
    public bool IsAnagram(string s, string t) {
        var hash = new int[256];
        foreach (var c in s) hash[c]++;
        foreach (var c in t) hash[c]--;
        foreach (var i in hash)
            if (i != 0) return false;
        return true;
    }
}