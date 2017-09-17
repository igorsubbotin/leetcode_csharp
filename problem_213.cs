// 213. House Robber II - https://leetcode.com/problems/house-robber-ii
public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) return nums[0];
        return Math.Max(Rob(nums, 0, nums.Length - 1), Rob(nums, 1, nums.Length));
    }
    
    private static int Rob(int[] nums, int left, int right) {
        var prevNo = 0;
        var prevYes = 0;
        for (var i = left; i < right; i++) {
            var tmp = prevNo;
            prevNo = Math.Max(prevYes, prevNo);
            prevYes = nums[i] + tmp;
        }
        return Math.Max(prevYes, prevNo);
    }
}