// 171. Excel Sheet Column Number - https://leetcode.com/problems/excel-sheet-column-number
public class Solution {
    public int TitleToNumber(string s) {
        var list = new List<int>();
        foreach (var c in s) {
            list.Add(((int)c)-64);
        }
        list.Reverse();
        var result = 0;
        var i = 1;
        foreach (var n in list) {
            result += n * i;
            i *= 26;
        }
        return result;
    }
}