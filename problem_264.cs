// 264. Ugly Number II - https://leetcode.com/problems/ugly-number-ii
public class Solution {
    public int NthUglyNumber(int n) {
        var ugly = new int[n];
        ugly[0] = 1;
        var index2 = 0;
        var index3 = 0; 
        var index5 = 0;
        var factor2 = 2;
        var factor3 = 3;
        var factor5 = 5;
        for (var i = 1; i < n; i++) {
            var min = Math.Min(Math.Min(factor2, factor3), factor5);
            ugly[i] = min;
            if(factor2 == min) factor2 = 2 * ugly[++index2];
            if(factor3 == min) factor3 = 3 * ugly[++index3];
            if(factor5 == min) factor5 = 5 * ugly[++index5];
        }
        return ugly[n - 1];
    }
}