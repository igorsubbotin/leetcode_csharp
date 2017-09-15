// 581. Shortest Unsorted Continuous Subarray - https://leetcode.com/problems/shortest-unsorted-continuous-subarray
public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        var right = 0;
        var max = int.MinValue;
        for (var i = 0; i < nums.Length; i++) {
            max = Math.Max(nums[i], max);
            if (max > nums[i]) right = i;
        }
        var left = nums.Length;
        for (var i = nums.Length - 1; i > 0; i--) {
            if (nums[i] < nums[i - 1]) {
                var tmp = nums[i];
                nums[i] = nums[i - 1];
                nums[i - 1] = tmp;
                left = i - 1;
            }
        }
        return Math.Max(0, right - left + 1);
    }
}