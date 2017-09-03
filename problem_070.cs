// 70. Climbing Stairs - https://leetcode.com/problems/climbing-stairs
public class Solution {
    public int ClimbStairs(int n) {
        var v = new int[n + 1];
        v[0] = 1;
        for (var i = 0; i < n; i++) {
            v[i + 1] += v[i];
            if (i + 2 > n) continue;
            v[i + 2] += v[i];
        }
        return v[n];
    }
}