// 179. Largest Number - https://leetcode.com/problems/largest-number
public class Solution {
    public string LargestNumber(int[] nums) {
        if (nums.Length == 0) return string.Empty;
        var str = nums.Select(x => x.ToString()).ToArray();
        var n = 0;
        foreach (var each in str) n += each.Length;
        Array.Sort(str, new Comparison<string>(
                            (a, b) => {
                                var s1 = a + b;
                                var s2 = b + a;
                                return s2.CompareTo(s1);
                            }));
        var sb = new StringBuilder();
        foreach (var each in str) sb.Append(each);
        var result = sb.ToString();
        if (result[0] == '0') return "0";
        return result;
    }
}