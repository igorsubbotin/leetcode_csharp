// 3Sum Closest - https://leetcode.com/problems/3sum-closest
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        var min = int.MaxValue;
        var result = 0;
        for (var i = 0; i < nums.Length; i++) {
            var j = i + 1;
            var k = nums.Length - 1;
            while (j < k) {
                var sum = nums[i] + nums[j] + nums[k];
                var diff = target - sum;
                if (diff > 0) j++;
                else if (diff < 0) k--;
                else return sum;
                var abs = Math.Abs(diff);
                if (abs < min) {
                    min = abs;
                    result = sum;
                }
                
            }
        }
        return result;
    }
}