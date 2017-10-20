// 540. Single Element in a Sorted Array - https://leetcode.com/problems/single-element-in-a-sorted-array
public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        var left = 0; 
        var right = nums.Length / 2;
        while (left < right) {
            var median = (left + right) / 2;
            if (nums[2 * median] != nums[2 * median + 1]) right = median;
            else left = median + 1;
        }
        return nums[2 * left];
    }
}