// 263. Ugly Number - https://leetcode.com/problems/ugly-number
public class Solution {
    public bool IsUgly(int num) {
        if (num < 1) return false;
        if (num == 1) return true;
        var primes = FindPrimes(1000);
        var factors = Factorize(num, primes);
        foreach (var f in factors)
            if (f[0] != 2 && f[0] != 3 && f[0] != 5) return false;
        return true;
    }
    
    private static int ApproximateNthPrime(int nn)
    {
        var n = (double)nn;
        double p;
        if (nn >= 7022) p = n * Math.Log(n) + n * (Math.Log(Math.Log(n)) - 0.9385);
        else if (nn >= 6) p = n * Math.Log(n) + n * Math.Log(Math.Log(n));
        else if (nn > 0) p = new int[] { 2, 3, 5, 7, 11 }[nn - 1];
        else p = 0;
        return (int)p;
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

    private static int[] FindPrimes(int n)
    {
        var limit = ApproximateNthPrime(n);
        var bits = SieveOfEratosthenes(limit);
        var primes = new List<int>();
        for (int i = 0, found = 0; i < limit && found < n; i++) {
            if (bits[i]) {
                primes.Add(i);
                found++;
            }
        }
        return primes.ToArray();
    }
    
    private static IList<int[]> Factorize(int n, int[] primes) {
        var factors = new List<int[]>();
        foreach (var p in primes) {
            if (p * p > n) break;
            var i = 0;
            while (n % p == 0) {
                n /= p;
                i++;
            }
            if (i > 0) factors.Add(new [] { p, i });
        }
        if (n > 1) factors.Add(new [] { n, 1 });
        return factors;
    }
}