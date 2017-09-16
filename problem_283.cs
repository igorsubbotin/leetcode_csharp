// 283. Move Zeroes - https://leetcode.com/problems/move-zeroes
public class Solution {
    public void MoveZeroes(int[] nums) {
        for (var i = nums.Length - 1; i >= 0; i--) {
            if (nums[i] != 0) continue;
            var j = i;
            while (j < nums.Length - 1 && nums[j + 1] != 0) {
                var tmp = nums[j];
                nums[j] = nums[j + 1];
                nums[j + 1] = tmp;
                j++;
            }
        }
    }
}