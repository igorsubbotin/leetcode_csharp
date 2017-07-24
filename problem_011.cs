// 11. Container With Most Water - https://leetcode.com/problems/container-with-most-water
public class Solution {
    public int MaxArea(int[] height) {
        var max = 0;
        var i = 0;
        var j = height.Length - 1;
        while (i < j) {
            max = Math.Max(max, (j - i) * Math.Min(height[i], height[j]));
            if (height[i] > height[j]) j--;
            else i++;
        }
        return max;
    }
}