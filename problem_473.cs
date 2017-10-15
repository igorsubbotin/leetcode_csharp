// 473. Matchsticks to Square - https://leetcode.com/problems/matchsticks-to-square
public class Solution {
    public bool Makesquare(int[] nums) {
        if (nums == null || nums.Length < 4) return false;
        var sum = 0;
        foreach (var num in nums) sum += num;
        if (sum % 4 != 0) return false;  
        Array.Sort(nums);
        Array.Reverse(nums);
        return dfs(nums, new int[4], 0, sum / 4);
    }
    
    private static bool dfs(int[] nums, int[] sums, int index, int target) {
    	if (index == nums.Length) {
    	    if (sums[0] == target && sums[1] == target && sums[2] == target) {
    		    return true;
    	    }
    	    return false;
    	}
    	
    	for (var i = 0; i < 4; i++) {
    	    if (sums[i] + nums[index] > target) continue;
    	    sums[i] += nums[index];
            if (dfs(nums, sums, index + 1, target)) return true;
    	    sums[i] -= nums[index];
    	}
    	
    	return false;
    }
}