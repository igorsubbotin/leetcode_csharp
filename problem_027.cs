// 27. Remove Element - https://leetcode.com/problems/remove-element
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var result = 0;
        var i = 0;
        var j = 0;
        while (i < nums.Length) {
            if (nums[i] != val) {
                result++;
                nums[j] = nums[i];
                j++;
            }
            i++;
        }
        return result;
    }
}