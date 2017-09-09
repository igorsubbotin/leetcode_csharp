// 567. Permutation in String - https://leetcode.com/problems/permutation-in-string
public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var hash = new int[256];
        foreach (var c in s1) {
            hash[c]++;
        }
        var source = hash.ToList().ToArray();
        var left = 0;
        var right = 0;
        var count = s1.Length;
        while (right < s2.Length) {
            hash[s2[right]]--;
            if (hash[s2[right]] >= 0) {
                count--;
            }
            right++;
            if (count == 0) return true;
            if (right - left == s1.Length && ++hash[s2[left++]] > 0) count++;
        }
        return false;
    }
}