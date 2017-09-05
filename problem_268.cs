// 268. Missing Number - https://leetcode.com/problems/missing-number
public class Solution {
    public int MissingNumber(int[] nums) {
        for (var i = 0; i < nums.Length; i++) {
            var value = nums[i];
            if (value < 0) continue;
            nums[i] = -1;
            while (value >= 0) {
                var ix = value;
                if (ix >= nums.Length) break;
                value = nums[ix];
                nums[ix] = -2;
            }
        }
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] == -1) return i;
        }
        return nums.Length;
    }
}