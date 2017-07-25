// 15. 3Sum - https://leetcode.com/problems/3sum
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        if (nums.Length < 3) return result;
        Array.Sort(nums);
        for (var i = 0; i < nums.Length - 2; i++) {
            if (i > 0 && nums[i] == nums[i-1]) continue;
            var j = i + 1;
            var k = nums.Length - 1;
            while (j < k) {
                var sum = nums[i] + nums[j] + nums[k];
                if (sum > 0) k--;
                else if (sum < 0) j++;
                else {
                    j++;
                    k--;
                    result.Add(new List<int> { nums[i], nums[j], nums[k] });
                    while (j < k && nums[j] == nums[j-1]) j++;
                    while (j < k && nums[k] == nums[k+1]) k--;
                }
            }
        } 
        return result;
    }
}