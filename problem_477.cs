// 477. Total Hamming Distance - https://leetcode.com/problems/total-hamming-distance
public class Solution {
    public int TotalHammingDistance(int[] nums) {
        var result = 0;
        for (var i = 0; i < 32; i++) {
            var bitCount = 0;
            for (var j = 0; j < nums.Length; j++) 
                bitCount += (nums[j] >> i) & 1;
            result += bitCount * (nums.Length - bitCount);
        }
        return result;
    }
}