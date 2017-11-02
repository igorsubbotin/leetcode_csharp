// 228. Summary Ranges - https://leetcode.com/problems/summary-ranges
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        if (nums.Length == 0) return new List<string>();
        var ranges = new List<int[]> { new [] { nums[0], nums[0] } };
        for (var i = 1; i < nums.Length; i++) {
            var last = ranges.Last();
            if (last[1] + 1 == nums[i]) last[1]++;
            else ranges.Add(new [] { nums[i], nums[i] });
        }
        var result = new List<string>();
        foreach (var range in ranges) {
            if (range[0] == range[1]) result.Add(range[0].ToString());
            else result.Add(string.Format("{0}->{1}", range[0], range[1]));
        }
        return result;
    }
}