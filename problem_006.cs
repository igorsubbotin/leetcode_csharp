// 6. ZigZag Conversion - https://leetcode.com/problems/zigzag-conversion
public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        var result = new StringBuilder();
        var step = GetStepSize(numRows);
        for (var i = 0; i < numRows; i++) {
            var j = i;
            var substep = GetStepSize(numRows - i);
            while (j < s.Length) {
                result.Append(s[j]);
                if (i != 0 && i != numRows - 1) {
                    var k = j + substep;
                    if (k < s.Length) result.Append(s[k]);
                }
                j += step;
            }
        }
        return result.ToString();
    }
    
    private static int GetStepSize(int numRows) {
        return (numRows - 2) * 2 + 2;
    }
}