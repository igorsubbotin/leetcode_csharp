// 693. Binary Number with Alternating Bits - https://leetcode.com/problems/binary-number-with-alternating-bits
public class Solution {
    public bool HasAlternatingBits(int n) {
        bool? prev = null;
        while (n > 0) {
            var bit = n % 2 == 0;
            if (prev != null && prev.Value == bit) return false;
            prev = bit;
            n /= 2;
        }
        return true;
    }
}