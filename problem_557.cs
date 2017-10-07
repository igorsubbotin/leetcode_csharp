// 557. Reverse Words in a String III - https://leetcode.com/problems/reverse-words-in-a-string-iii
public class Solution {
    public string ReverseWords(string s) {
        var sb = new StringBuilder(s);
        var right = 0;
        while (right < sb.Length) {
            var left = right;
            while (right < sb.Length && sb[right] != ' ') {
                right++;
            }
            Reverse(sb, left, right - 1);
            right++;
        }
        return sb.ToString();
    }
    
    private void Reverse(StringBuilder sb, int left, int right) {
        var length = right - left + 1;
        for (var i = 0; i < length / 2; i++) {
            var tmp = sb[left + i];
            sb[left + i] = sb[right - i];
            sb[right - i] = tmp;
        }
    }
}