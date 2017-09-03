// 58. Length of Last Word - https://leetcode.com/problems/length-of-last-word
public class Solution {
    public int LengthOfLastWord(string s) {
        var result = 0;
        for (var i = s.Length - 1; i >= 0; i--) {
            if ((int)s[i] == 32) {
                if (result != 0) return result;
            }
            else result++;
        }
        return result;
    }
}