// 205. Isomorphic Strings - https://leetcode.com/problems/isomorphic-strings
public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var d = new Dictionary<char, char>();
        var hs = new HashSet<char>();
        for (var i = 0; i < s.Length; i++) {
            var s_contains = d.ContainsKey(s[i]);
            var t_contains = hs.Contains(t[i]);
            if ((s_contains && !t_contains) || (!s_contains && t_contains)) return false;
            if (!s_contains && !t_contains) {
                d.Add(s[i], t[i]);
                hs.Add(t[i]);
            }
            if (d[s[i]] != t[i]) return false;
        }
        return true;
    }
}