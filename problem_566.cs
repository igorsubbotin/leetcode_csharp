// 566. Reshape the Matrix - https://leetcode.com/problems/reshape-the-matrix
public class Solution {
    public int[,] MatrixReshape(int[,] nums, int r, int c) {
        var rows = nums.GetLength(0);
        var columns = nums.GetLength(1);
        if (r * c != rows * columns) return nums;
        var reshape = new int[r, c];
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < columns; j++) {
                var ix = i * columns + j;
                reshape[ix / c, ix % c] = nums[i, j];
            }
        }
        return reshape;
    }
}