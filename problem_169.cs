// 169. Majority Element - https://leetcode.com/problems/majority-element
public class Solution {
    public int MajorityElement(int[] nums) {
        var d = new Dictionary<int, int>();
        foreach (var n in nums) {
            if (!d.ContainsKey(n)) d[n] = 0;
            d[n]++;
        }
        var max = 0;
        var result = 0;
        foreach (var each in d) {
            if (each.Value > max) {
                max = each.Value;
                result = each.Key;
            }
        }
        return result;
    }
}