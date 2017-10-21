// 522. Longest Uncommon Subsequence II - https://leetcode.com/problems/longest-uncommon-subsequence-ii
public class Solution {
    public int FindLUSlength(string[] strs) {
        if (strs.Length == 0) return -1;
        if (strs.Length == 1) return strs[0].Length;
        strs = strs.OrderByDescending(x => x.Length).ToArray();
        if (strs[0].Length != strs[1].Length) return Math.Max(strs[0].Length, strs[1].Length);
        for (var i = 0; i < strs.Length; i++) {
            var subsequence = false;
            for (var j = 0; j < strs.Length; j++) {
                if (i == j) continue;
                if (IsSubsequenceOf(strs[i], strs[j])) {
                    subsequence = true;
                    break;
                }
            }
            if (!subsequence) return strs[i].Length;
        }
        return -1;
    }
    
    private static bool IsSubsequenceOf(string source, string target) {
        if (source.Length > target.Length) return false;
        if (source.Length == target.Length) return source == target;
        var i = 0;
        var j = 0;
        while (i < source.Length && j < target.Length) {
            if (source[i] == target[j]) i++;
            j++;
        }
        return i == source.Length;
    }
}