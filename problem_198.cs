// 198. House Robber - https://leetcode.com/problems/house-robber
public class Solution {
    public int Rob(int[] nums) {
        var prevNo = 0;
        var prevYes = 0;
        for (var i = 0; i < nums.Length; i++) {
            var tmp = prevNo;
            prevNo = Math.Max(prevYes, prevNo);
            prevYes = nums[i] + tmp;    
        }
        return Math.Max(prevYes, prevNo);
    }
}