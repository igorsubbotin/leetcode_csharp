// 645. Set Mismatch - https://leetcode.com/problems/set-mismatch
public class Solution {
    public int[] FindErrorNums(int[] nums) {
        for (var i = 0; i < nums.Length; i++) {
            var value = nums[i];
            if (value <= 0) continue;
            nums[i] = 0;
            while (value > 0) {
                var ix = value - 1;
                value = nums[ix];
                if (nums[ix] > 0) nums[ix] = 0;
                nums[ix]--;
            }
        }
        var duplicate = 0;
        var missing = 0;
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) missing = i + 1;
            if (nums[i] == -2) duplicate = i + 1;
        }
        return new [] { duplicate, missing };
    }
}