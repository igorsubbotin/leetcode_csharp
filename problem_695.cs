// 695. Max Area of Island - https://leetcode.com/problems/max-area-of-island/description
public class Solution {
    public int MaxAreaOfIsland(int[,] grid) {
        var r = grid.GetLength(0);
        var c = grid.GetLength(1);
        var max = 0;
        for (var i = 0; i < r; i++) {
            for (var j = 0; j < c; j++) {
                if (grid[i, j] == 0) continue;
                var s = 0;
                var q = new Queue<int[]>();
                q.Enqueue(new [] { i, j });
                grid[i, j] = 0;
                while (q.Count > 0) {
                    var item = q.Dequeue();
                    var row = item[0];
                    var column = item[1];
                    s++;
                    if (row - 1 >= 0 && grid[row - 1, column] == 1) {
                        grid[row - 1, column] = 0;
                        q.Enqueue(new [] { row - 1, column });
                    }
                    if (row + 1 < r && grid[row + 1, column] == 1) {
                        grid[row + 1, column] = 0;
                        q.Enqueue(new [] { row + 1, column });
                    }
                    if (column - 1 >= 0 && grid[row , column - 1] == 1) {
                        grid[row, column - 1] = 0;
                        q.Enqueue(new [] { row, column - 1 });
                    }
                    if (column + 1 < c && grid[row, column + 1] == 1) {
                        grid[row, column + 1] = 0;
                        q.Enqueue(new [] { row, column + 1 });
                    }
                }
                max = Math.Max(s, max);                
            }
        }
        return max;
    }
}