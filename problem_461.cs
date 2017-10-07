// 461. Hamming Distance - https://leetcode.com/problems/hamming-distance
public class Solution {
    public int HammingDistance(int x, int y) {
        var result = 0;
        var n = x ^ y;
        while (n > 0) {
            result += n % 2;
            n /= 2;
        }
        return result;
    }
}