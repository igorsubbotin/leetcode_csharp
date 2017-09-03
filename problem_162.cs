// 162. Find Peak Element - https://leetcode.com/problems/find-peak-element
public class Solution {
    public int FindPeakElement(int[] nums) {
        var max = int.MinValue;
        var ix = 0;
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] > max) {
                max = nums[i];
                ix = i;
            }
        }
        return ix;
    }
}