// 500. Keyboard Row - https://leetcode.com/problems/keyboard-row
public class Solution {
    public string[] FindWords(string[] words) {
        var rows = new [] {
            new HashSet<char> { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' },
            new HashSet<char> { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' },
            new HashSet<char> { 'z', 'x', 'c', 'v', 'b', 'n', 'm' }
        };
        var result = new List<string>();
        foreach (var source in words) {
            var word = source.ToLower();
            var firstChar = word[0];
            HashSet<char> row = null;
            for (var i = 0; i < 3; i++) {
                row = rows[i];
                if (row.Contains(firstChar)) break;
            }
            var ok = true;
            foreach (var c in word) {
                if (!row.Contains(c)) {
                    ok = false;
                    break;
                }
            }
            if (ok) result.Add(source);
        }
        return result.ToArray();
    }
}