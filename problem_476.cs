// 476. Number Complement - https://leetcode.com/problems/number-complement
public class Solution {
    public int FindComplement(int num) {
        var bits = ToBits(num);
        RevertBits(bits);
        return ToInt32(bits);
    }
    private static List<int> ToBits(int n) {
        var result = new List<int>();
        while (n > 0) {
            result.Add((int)(n % 2));
            n /= 2;
        }
        return result;
    }
    private static void RevertBits(IList<int> bits) {
        for (var i = 0; i < bits.Count; i++) {
            if (bits[i] == 0) bits[i] = 1;
            else bits[i] = 0;
        }
    }
    private static int ToInt32(IList<int> bits) {
        var result = 0;
        var m = 1;
        for (var i = 0; i < bits.Count; i++) {
            result += bits[i] * m;
            m *= 2;
        }
        return result;
    }
}