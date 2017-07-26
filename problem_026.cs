// 26. Remove Duplicates from Sorted Array - https://leetcode.com/problems/remove-duplicates-from-sorted-array
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        var prev = nums[0];
        var i = 1;
        var j = 1;
        var n = 1;
        while (i < nums.Length) {
            if (nums[i] != prev) {
                nums[j] = nums[i];
                n++;
                j++;
            }
            prev = nums[i];
            i++;
        }
        return n;
    }
}