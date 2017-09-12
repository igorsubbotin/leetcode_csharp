// 209. Minimum Size Subarray Sum - https://leetcode.com/problems/minimum-size-subarray-sum
public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        if (nums.Length == 0) return 0;
        var left = 0;
        var right = 0;
        var min = int.MaxValue;
        s -= nums[0];
        while (!(left + 1 == nums.Length || (right + 1 == nums.Length && s > 0))) {
            if (s <= 0) {
                min = Math.Min(min, right - left + 1);
                s += nums[left++];
                if (right < left) right = left;
            } else if (right + 1 < nums.Length) s -= nums[++right];
        }
        if (min == int.MaxValue) return 0;
        return min;
    }
}