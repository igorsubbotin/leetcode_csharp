// 290. Word Pattern - https://leetcode.com/problems/word-pattern
public class Solution {
    public bool WordPattern(string pattern, string str) {
        var d = new Dictionary<char, string>();
        var hs = new HashSet<string>();
        var split = str.Split(null);
        if (split.Length != pattern.Length) return false;
        for (var i = 0; i < split.Length; i++) {
            var c = pattern[i];
            var word = split[i];
            if (d.ContainsKey(c)) {
                if (d[c] != word) return false;
            } else {
                if (hs.Contains(word)) return false;
                d[c] = word;
                hs.Add(word);
            }
        }
        return true;
    }
}