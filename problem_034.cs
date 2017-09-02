// 34. Search for a Range - https://leetcode.com/problems/search-for-a-range
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        var index = FindIndex(nums, target, 0, nums.Length - 1);
        if (index == -1) return new[] { -1, -1 };
        var left = index;
        while (left >= 0) {
            if (nums[left] != target) break;
            left--;
        }
        var right = index;
        while (right < nums.Length) {
            if (nums[right] != target) break;
            right++;
        }
        return new[] { left + 1, right - 1 };
    }
    
    private static int FindIndex(int[] nums, int target, int left, int right) {
        var length = right - left + 1;
        if (length == 0) return -1;
        var median = left + length / 2;
        if (length < 3) {
            if (target == nums[left]) return left;
            if (target == nums[right]) return right;
            return -1;
        }
        if (target < nums[median]) return FindIndex(nums, target, left, median - 1);
        else if (target > nums[median]) return FindIndex(nums, target, median + 1, right);
        return median;
    }
}