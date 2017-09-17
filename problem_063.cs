// 63. Unique Paths II - https://leetcode.com/problems/unique-paths-ii
public class Solution {
    public int UniquePathsWithObstacles(int[,] obstacleGrid) {
        var m = obstacleGrid.GetLength(0);
        var n = obstacleGrid.GetLength(1);
        var dp = new int[m, n];
        if (obstacleGrid[m - 1, n - 1] != 1) dp[m - 1, n - 1] = 1;
        for (var i = m - 1; i >= 0; i--) {
            for (var j = n - 1; j >= 0; j--) {
                if (i - 1 >= 0 && obstacleGrid[i - 1, j] == 0) dp[i - 1, j] += dp[i, j];
                if (j - 1 >= 0 && obstacleGrid[i, j - 1] == 0) dp[i, j - 1] += dp[i, j];
            }
        }
        return dp[0, 0];
    }
}