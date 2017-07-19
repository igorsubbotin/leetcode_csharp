// Two Sum - https://leetcode.com/problems/two-sum/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var d = new Dictionary<int, List<int>>();
        for (var i = 0; i < nums.Length; i++) {
            if (!d.ContainsKey(nums[i])) d[nums[i]] = new List<int>();
            d[nums[i]].Add(i);
        }
        for (var i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            if (!d.ContainsKey(diff)) continue;
            var list = d[diff];
            for (var j = 0; j < list.Count; j++) {
                if (list[j] != i) return new [] { i, list[j] };
            }
        }
        return null;
    }
}