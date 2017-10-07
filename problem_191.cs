// 191. Number of 1 Bits - https://leetcode.com/problems/number-of-1-bits
public class Solution {
    public int HammingWeight(uint n) {
        var result = 0;
        while (n > 0) {
            result += (int)(n % 2);
            n /= 2;
        }
        return result;
    }
}