// 67. Add Binary - https://leetcode.com/problems/add-binary
public class Solution {
    public string AddBinary(string a, string b) {
        var shift = 0;
        var result = new List<int>();
        for (var i = 0; i < Math.Max(a.Length, b.Length); i++) {
            var x = 0;
            var y = 0;
            if (i < a.Length) x = int.Parse(a[a.Length - i - 1].ToString());
            if (i < b.Length) y = int.Parse(b[b.Length - i - 1].ToString());
            var sum = x + y + shift;
            result.Add(sum % 2);
            shift = sum / 2;
        }
        if (shift == 1) result.Add(1);
        result.Reverse();
        return string.Join("", result.Select(x => x.ToString()));
    }
}