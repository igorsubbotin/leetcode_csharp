// 463. Island Perimeter - https://leetcode.com/problems/island-perimeter
public class Solution {
    public int IslandPerimeter(int[,] grid) {
        var result = 0;
        for (var i = 0; i < grid.GetLength(0); i++)
            for (var j = 0; j < grid.GetLength(1); j++)
                result += GetPerimeter(i, j, grid);
        return result;
    }
    
    private static int GetPerimeter(int x, int y, int[,] grid) {
        var result = 0;
        if (grid[x, y] == 0) return result;
        var length = grid.GetLength(0);
        var width = grid.GetLength(1);
        if (x == 0 || grid[x - 1, y] != 1) result += 1;
        if (x + 1 == length || grid[x + 1, y] != 1) result += 1;
        if (y == 0 || grid[x, y - 1] != 1) result += 1;
        if (y + 1 == width || grid[x, y + 1] != 1) result += 1;
        return result; 
    }
}