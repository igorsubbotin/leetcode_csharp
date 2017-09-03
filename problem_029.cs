// 29. Divide Two Integers - https://leetcode.com/problems/divide-two-integers
public class Solution {
    public int Divide(int dividend, int divisor) {
        long dnd = (long)dividend;
        long dvr = (long)divisor;
        if (dvr == 0) return int.MaxValue;
        
        var sign = GetResultSign(dnd, dvr);
        dnd = Abs(dnd);
        dvr = Abs(dvr);
        long n = 0;
        while (dnd >= dvr) {
            var result = RawDivide(dnd, dvr);
            dnd -= result[0];
            n += result[1];
        }
        
        return GetResult(n, sign);
    }
    
    private static long[] RawDivide(long dividend, long divisor) {
        long i = 1;
        long n = divisor;
        while (true) {
            long twice = n + n;
            if (twice > dividend) return new[] { n, i };
            i += i;
            n = twice;
        }
        return null;
    }
    
    private static long Abs(long n) {
        return (n + (n >> 31)) ^ (n >> 31);
    }
    
    private static long GetResultSign(long a, long b) {
        var a_sign = GetSign(a);
        var b_sign = GetSign(b);
        if (a_sign == b_sign) return 1;
        return -1;
    }
    
    private static long GetSign(long n) {
        if (n < 0) return -1;
        return 1;
    }
    
    private static long SetSign(long n, long sign) {
        if (sign == 1) return n;
        return 0 - n;
    }
    
    private static int GetResult(long n, long sign) {
        var result = SetSign(n, sign);
        if (result > int.MaxValue || result < int.MinValue) return int.MaxValue;
        return (int)result;
    }
}