// 240. Search a 2D Matrix II - https://leetcode.com/problems/search-a-2d-matrix-ii
public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        var R = matrix.GetLength(0);
        var C = matrix.GetLength(1);
        if (R == 0 || C == 0) return false;
        var r = 0;
        var c = C - 1;
        while (r < R && c >= 0) {
            if (matrix[r, c] > target) {
                c--;
            } else if (matrix[r, c] < target) {
                r++;
            } else {
                return true;
            }
        }
        return false;
    }
}