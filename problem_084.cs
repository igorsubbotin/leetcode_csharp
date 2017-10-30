// 84. Largest Rectangle in Histogram - https://leetcode.com/problems/largest-rectangle-in-histogram
public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var max = 0;
        var s = new Stack<int[]>(); // height, count
        var count = 0;
        for (var i = 0; i < heights.Length; i++) {
            count = 0;
            while (s.Count > 0 && s.Peek()[0] >= heights[i]) {
                var item = s.Pop();
                count += item[1];
                max = Math.Max(max, item[0] * count);
            }
            count++;
            s.Push(new [] { heights[i], count });
        }
        count = 0;
        while (s.Count > 0) {
            var item = s.Pop();
            count += item[1];
            max = Math.Max(max, item[0] * count);
        }
        return max;
    }
}