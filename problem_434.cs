// 434. Number of Segments in a String - https://leetcode.com/problems/number-of-segments-in-a-string
public class Solution {
    public int CountSegments(string s) {
        var result = 0;
        var space = true;
        var i = 0;
        while (i < s.Length) {
            if (s[i] == ' ') space = true;
            else if (space) {
                space = false;
                result++;
            }
            i++;
        }
        return result;
    }
}