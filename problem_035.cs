// 35. Search Insert Position - https://leetcode.com/problems/search-insert-position
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return FindIndex(nums, target, 0, nums.Length - 1);
    }
    
    private static int FindIndex(int[] nums, int target, int left, int right) {
        var length = right - left + 1;
        var median = left + length / 2;
        if (target == nums[median]) return median;
        if (length == 1) {
            if (target < nums[left]) return left;
            return left + 1;
        }
        if (length == 2) {
            if (target <= nums[left]) return left;
            if (target <= nums[right]) return right;
            return right + 1;
        }
        if (target < nums[median]) return FindIndex(nums, target, left, median - 1);
        return FindIndex(nums, target, median + 1, right);
    }
}