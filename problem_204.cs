// 204. Count Primes - https://leetcode.com/problems/count-primes
public class Solution {
    public int CountPrimes(int n) {
        if (n < 2) return 0;
        var bits = SieveOfEratosthenes(n);
        var result = 0;
        for (int i = 0; i < n; i++)
            if (bits[i]) result++;
        return result;
    }
    
    private static BitArray SieveOfEratosthenes(int limit)
    {
        var bits = new BitArray(limit + 1, true);
        bits[0] = false;
        bits[1] = false;
        for (var i = 0; i * i <= limit; i++)
            if (bits[i])
                for (int j = i * i; j <= limit; j += i)
                    bits[j] = false;
        return bits;
    }
}