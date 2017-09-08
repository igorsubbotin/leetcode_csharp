// 168. Excel Sheet Column Title - https://leetcode.com/problems/excel-sheet-column-title
public class Solution {
    public string ConvertToTitle(int n) {
        n--;
        var list = new List<int>();
        while (n >= 0) {
            list.Add(n % 26);
            n = n / 26 - 1;
        }
        list.Reverse();
        var result = string.Empty;
        foreach (var code in list) {
            result += (char)(code + 65);
        }
        return result;
    }
}