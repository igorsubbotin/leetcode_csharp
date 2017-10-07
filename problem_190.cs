// 190. Reverse Bits - https://leetcode.com/problems/reverse-bits
public class Solution {
    public uint reverseBits(uint n) {
        var bitArray = ToBitArray(n);
        Reverse(bitArray);
        return ToUInt32(bitArray);
    }
    
    private static uint[] ToBitArray(uint n) {
        var result = new uint[32];
        var i = 0;
        while (n > 0) {
            result[i++] = n % 2;
            n /= 2;
        }
        return result;
    }
    private static void Reverse(uint[] bitArray) {
        for (var i = 0; i < bitArray.Length / 2; i++) {
            var tmp = bitArray[i];
            bitArray[i] = bitArray[bitArray.Length - i - 1];
            bitArray[bitArray.Length - i - 1] = tmp;
        }
    }
    private static uint ToUInt32(uint[] bitArray) {
        uint result = 0;
        uint m = 1;
        for (var i = 0; i < 32; i++) {
            result += bitArray[i] * m;
            m *= 2;
        }
        return result;
    }
}