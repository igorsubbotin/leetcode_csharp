// 496. Next Greater Element I - https://leetcode.com/problems/next-greater-element-i
public class Solution {
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        var result = new int[findNums.Length];
        for (var i = 0; i < findNums.Length; i++) {
            result[i] = -1;
            var j = 0;
            while (nums[j] != findNums[i]) j++;
            while (j < nums.Length) {
                if (findNums[i] < nums[j]) {
                    result[i] = nums[j];
                    break;
                }
                j++;
            }
        }
        return result;
    }
}