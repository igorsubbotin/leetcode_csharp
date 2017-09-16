// 344. Reverse String - https://leetcode.com/problems/reverse-string
public class Solution {
    public string ReverseString(string s) {
        var sb = new StringBuilder(s);
        for (var i = 0; i < s.Length / 2; i++) {
            var tmp = sb[i];
            sb[i] = sb[s.Length - i - 1];
            sb[s.Length - i - 1] = tmp;
        }
        return sb.ToString();
    }
}