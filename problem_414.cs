// 414. Third Maximum Number - https://leetcode.com/problems/third-maximum-number
public class Solution {
    public int ThirdMax(int[] nums) {
        var max = int.MinValue;
        for (var i = 0; i < nums.Length; i++) max = Math.Max(max, nums[i]);
        var first = max;
        max = int.MinValue;
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] == first) continue;
            max = Math.Max(max, nums[i]);
        }
        var second = max;
        max = int.MinValue;
        var found = false;
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] == first || nums[i] == second) continue;
            found = true;
            max = Math.Max(max, nums[i]);
        }
        if (!found) return first;
        return max;
    }
}