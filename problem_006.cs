// 6. ZigZag Conversion - https://leetcode.com/problems/zigzag-conversion
public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        var result = string.Empty;
        var step = GetStepSize(numRows);
        for (var i = 0; i < numRows; i++) {
            var j = i;
            while (j < s.Length) {
                result += s[j];
                if (i != 0 && i != numRows - 1) {
                    var k = j + GetStepSize(numRows - i);
                    if (k < s.Length) result += s[k];
                }
                j += step;
            }
        }
        return result;
    }
    
    private static int GetStepSize(int numRows) {
        return (numRows - 2) * 2 + 2;
    }
}