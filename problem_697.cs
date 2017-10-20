// 697. Degree of an Array - https://leetcode.com/problems/degree-of-an-array
public class Solution {
    public int FindShortestSubArray(int[] nums) {
        var d = new Dictionary<int, int[]>(); // key, (count, start, end)
        var max = int.MinValue;
        for (var i = 0; i < nums.Length; i++) {
            if (!d.ContainsKey(nums[i])) d[nums[i]] = new [] { 0, i, 0 };
            d[nums[i]][0]++;
            d[nums[i]][2] = i;
            max = Math.Max(max, d[nums[i]][0]);
        }
        var length = int.MaxValue;
        foreach (var key in d.Keys) {
            if (d[key][0] != max) continue;
            length = Math.Min(length, d[key][2] - d[key][1] + 1);
        }
        return length;
    }
}