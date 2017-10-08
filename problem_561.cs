// 561. Array Partition I - https://leetcode.com/problems/array-partition-i
public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        var result = 0;
        for (var i = 0; i < nums.Length; i = i + 2) {
            result += nums[i];
        }
        return result;
    }
}