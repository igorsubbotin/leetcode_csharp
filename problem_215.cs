// 215. Kth Largest Element in an Array - https://leetcode.com/problems/kth-largest-element-in-an-array
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        Array.Sort(nums);
        return nums[nums.Length - k];
    }
}