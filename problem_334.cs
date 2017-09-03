// 334. Increasing Triplet Subsequence - https://leetcode.com/problems/increasing-triplet-subsequence
public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        if (nums.Length < 3) return false;
        var ix = 0;
        while (ix + 1 < nums.Length && nums[ix] >= nums[ix + 1]) ix++;
        if (ix == nums.Length - 1) return false;
        
        var min = nums[ix];
        var max = nums[ix + 1];
        for (var i = ix + 2; i < nums.Length; i++) {
            if (nums[i] > max) return true;
            if (i + 1 == nums.Length) break;
            if (nums[i] > nums[i + 1]) continue;
            if (nums[i] > min && nums[i] < max) max = nums[i];
            else if (nums[i] < min && nums[i + 1] < max) {
                min = nums[i];
                max = nums[i + 1];
            }
        }
        return false;
    }
}