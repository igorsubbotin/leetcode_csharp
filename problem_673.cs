// 673. Number of Longest Increasing Subsequence - https://leetcode.com/problems/number-of-longest-increasing-subsequence
public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        if (nums.Length == 0) return 0;
        var max = 0;
        var list = new List<int[]>();
        for (var i = 0; i < nums.Length; i++) list.Add(null);
        for (var i = nums.Length - 1; i >= 0; i--) {
            var m = 1;
            var d = new Dictionary<int, int> { { 1, 1 } };
            for (var j = i + 1; j < nums.Length; j++) {
                if (nums[j] > nums[i]) {
                    var length = 1 + list[j][0];
                    if (!d.ContainsKey(length)) d[length] = 0;
                    d[length] += list[j][1];
                    m = Math.Max(m, length);
                }
            }
            list[i] = new [] { m, d[m] };
            max = Math.Max(max, m);
        }
        var result = 0;
        for (var i = 0; i < list.Count; i++)
            if (list[i][0] == max) result += list[i][1];
        return result;
    }
}