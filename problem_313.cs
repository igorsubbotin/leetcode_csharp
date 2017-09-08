// 313. Super Ugly Number - https://leetcode.com/problems/super-ugly-number
public class Solution {
    public int NthSuperUglyNumber(int n, int[] primes) {
        var ugly = new int[n];
        ugly[0] = 1;
        var indexes = new int[primes.Length];
        var factors = new int[primes.Length];
        for (var i = 0; i < primes.Length; i++) {
            factors[i] = primes[i];
        }
        for (var i = 1; i < n; i++) {
            var min = GetMin(factors);
            ugly[i] = min;
            for (var j = 0; j < factors.Length; j++) {
                if (factors[j] == min) factors[j] = primes[j] * ugly[++indexes[j]];
            }
        }
        
        return ugly[n - 1];
    }
    
    private static int GetMin(int[] nums) {
        var min = int.MaxValue;
        for (var i = 0; i < nums.Length; i++) {
            min = Math.Min(min, nums[i]);
        }
        return min;
    }
}