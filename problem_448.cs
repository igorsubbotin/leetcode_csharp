// 448. Find All Numbers Disappeared in an Array - https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array
public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        for (var i = 0; i < nums.Length; i++) {
            var j = i;
            var value = nums[j];
            if (value == -1) continue;
            nums[j] = 0;
            while (value > 0) {
                var ix = value - 1;
                value = nums[ix];
                nums[ix] = -1;
            }
        }
        var result = new List<int>();
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] != -1) result.Add(i + 1);
        }
        return result;
    }
}