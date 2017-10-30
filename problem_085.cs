// 85. Maximal Rectangle - https://leetcode.com/problems/maximal-rectangle
public class Solution {
    public int MaximalRectangle(char[,] matrix) {
        var R = matrix.GetLength(0);
        var C = matrix.GetLength(1);
        if (C == 0 || R == 0) return 0;
        var lines = new List<int[]>(R);
        lines.Add(new int[C]);
        for (var c = 0; c < C; c++) lines[0][c] = int.Parse(matrix[0, c].ToString());
        for (var r = 1; r < R; r++) {
            var line = new int[C];
            for (var c = 0; c < C; c++) {
                if (matrix[r, c] == '0') continue;
                line[c] = 1 + lines.Last()[c];
            }
            lines.Add(line);
        }
        var max = 0;
        foreach (var heights in lines) max = Math.Max(max, MaximalRectangle(heights));
        return max;
    }
    
    private static int MaximalRectangle(int[] heights) {
        var max = 0;
        var s = new Stack<int[]>(); // height, count
        var count = 0;
        for (var i = 0; i < heights.Length; i++) {
            var height = heights[i];
            count = 0;
            while (s.Count > 0 && s.Peek()[0] >= height) {
                var item = s.Pop();
                count += item[1];
                max = Math.Max(max, item[0] * count);
            }
            count++;
            s.Push(new [] { height, count });
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