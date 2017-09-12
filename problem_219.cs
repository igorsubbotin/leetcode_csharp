// 219. Contains Duplicate II - https://leetcode.com/problems/contains-duplicate-ii
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (nums.Length == 0) return false;
        var d = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++) {
            if (d.ContainsKey(nums[i]) && Math.Abs(d[nums[i]] - i) <= k) return true; 
            d[nums[i]] = i;
        }
        return false;
    }
}