// 657. Judge Route Circle - https://leetcode.com/problems/judge-route-circle
public class Solution {
    public bool JudgeCircle(string moves) {
        var x = 0;
        var y = 0;
        foreach (var c in moves) {
            if (c == 'U') y--;
            if (c == 'D') y++;
            if (c == 'L') x--;
            if (c == 'R') x++;
        } 
        return x == 0 && y == 0;
    }
}