// 438. Find All Anagrams in a String - https://leetcode.com/problems/find-all-anagrams-in-a-string
public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var hash = new int[256];
        foreach (var c in p) hash[c]++;
        var left = 0;
        var right = 0;
        var count = p.Length;
        var result = new List<int>();
        while (right < s.Length) {
            if (hash[s[right]] > 0) count--;
            hash[s[right]]--;
            right++;
            if (count == 0) result.Add(left);
            if (p.Length == right - left) {
                if (hash[s[left]] >= 0) count++;
                hash[s[left]]++;
                left++;
            }
        }
        return result;
    }
}