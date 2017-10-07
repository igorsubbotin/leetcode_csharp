// 231. Power of Two - https://leetcode.com/problems/power-of-two
public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n < 1) return false;
        var r = 0;
        while (n > 1) {
            r = n % 2;
            n /= 2;
            if (r != 0) return false;
        }
        return true;
    }
}