// 541. Reverse String II - https://leetcode.com/problems/reverse-string-ii
public class Solution {
    public string ReverseStr(string s, int k) {
        var sb = new StringBuilder(s);
        var step = k * 2;
        for (var i = 0; i < s.Length / step + 1; i++) {
            var left = i * step;
            var right = Math.Min(s.Length - 1, left + k - 1);
            Reverse(sb, left, right);
        }
        return sb.ToString();
    }
    
    private static void Reverse(StringBuilder sb, int left, int right) {
        var length = right - left + 1;
        for (var i = 0; i < length / 2; i++) {
            var tmp = sb[left + i];
            sb[left + i] = sb[right - i];
            sb[right - i] = tmp;
        }
    }
}