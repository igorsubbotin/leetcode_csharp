// 6. ZigZag Conversion - https://leetcode.com/problems/zigzag-conversion
public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        var result = new List<StringBuilder>();
        for (var j = 0; j <= numRows; j++)
            result.Add(new StringBuilder());
        var i = 0;
        var increase = true;
        var row = 1;
        while (i < s.Length) {
            result[row].Append(s[i]);
            if (increase) row++;
            else row--;
            if (row == 1) increase = true;
            else if (row == numRows) increase = false;
            i++;
        }
        var sb = new StringBuilder();
        foreach (var each in result)
            sb.Append(each.ToString());
        return sb.ToString();
    }
}