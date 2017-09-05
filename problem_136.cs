// 136. Single Number - https://leetcode.com/problems/single-number
public class Solution {
    public int SingleNumber(int[] nums) {
        var result = 0;
        for (var i = 0; i < nums.Length; i++) {
            result ^= nums[i];
        }
        return result;
    }
}