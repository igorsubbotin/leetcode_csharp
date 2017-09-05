// 442. Find All Duplicates in an Array - https://leetcode.com/problems/find-all-duplicates-in-an-array
public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        Array.Sort(nums);
        for (var i = 0; i < nums.Length; i++) {
            var value = nums[i];
            if (value <= 0) continue;
            nums[i] = 0;
            while (value > 0) {
                var ix = value - 1;
                value = nums[ix];
                if (value > 0) nums[ix] = 0;
                nums[ix] -= 1;
            }
        }
        var result = new List<int>();
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] == -2) result.Add(i + 1);
        }
        return result;
    }
}