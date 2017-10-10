// 200. Number of Islands - https://leetcode.com/problems/number-of-islands
public class Solution {
    public int NumIslands(char[,] grid) {
        var result = 0;
        var r = grid.GetLength(0);
        var c = grid.GetLength(1);
        for (var i = 0; i < r; i++) {
            for (var j = 0; j < c; j++) {
                if (grid[i, j] == '0') continue;
                result++;
                var q = new Queue<int[]>();
                q.Enqueue(new [] { i, j });
                while (q.Count > 0) {
                    var item = q.Dequeue();
                    var row = item[0];
                    var column = item[1];
                    grid[row, column] = '0';
                    if (row - 1 >= 0 && grid[row - 1, column] == '1') {
                        grid[row - 1, column] = '0';
                        q.Enqueue(new [] { row - 1, column });
                    }
                    if (row + 1 < r && grid[row + 1, column] == '1') {
                        grid[row + 1, column] = '0';
                        q.Enqueue(new [] { row + 1, column });
                    }
                    if (column - 1 >= 0 && grid[row, column - 1] == '1') {
                        grid[row, column - 1] = '0';
                        q.Enqueue(new [] { row, column - 1 });
                    }
                    if (column + 1 < c && grid[row, column + 1] == '1') {
                        grid[row, column + 1] = '0';
                        q.Enqueue(new [] { row, column + 1 });
                    }
                }
            }
        }
        return result;
    }
}