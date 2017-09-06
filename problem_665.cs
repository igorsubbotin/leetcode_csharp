// 665. Non-decreasing Array - https://leetcode.com/problems/non-decreasing-array
public class Solution {
    public bool CheckPossibility(int[] nums) {
        if (NonDecreasing(nums)) return true;
        for (var i = 0; i < nums.Length - 1; i++) {
            var first = nums[i];
            var second = nums[i + 1];
            if (first <= second) continue;
            nums[i] = first;
            nums[i + 1] = first;
            if (NonDecreasing(nums)) return true;
            nums[i] = second;
            nums[i + 1] = second;
            if (NonDecreasing(nums)) return true;
            nums[i] = first;
            nums[i + 1] = second;
        }
        return false;
    }
    
    private static bool NonDecreasing(int[] nums) {
        if (nums.Length == 0) return true;
        var prev = nums[0];
        for (var i = 1; i < nums.Length; i++) {
            if (prev > nums[i]) return false;
            prev = nums[i];
        }
        return true;
    }
}