// 540. Single Element in a Sorted Array - https://leetcode.com/problems/single-element-in-a-sorted-array
public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        return Find(nums, 0, nums.Length - 1);
    }
    
    private int Find(int[] nums, int left, int right) {
        var length = right - left + 1;
        if (length == 1) return nums[left];
        if (length == 3) {
            if (nums[left] == nums[left + 1]) return nums[left + 2];
            return nums[left];
        }
        var median = left + length / 2;
        if ((length - 1) / 2 % 2 == 0) {
            if (nums[median] == nums[median + 1]) return Find(nums, median, right);
            return Find(nums, left, median);
        } else {
            if (nums[median] == nums[median + 1]) return Find(nums, left, median - 1);
            return Find(nums, median + 1, right);
        }
    }
}