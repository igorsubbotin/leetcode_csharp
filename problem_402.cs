// 402. Remove K Digits - https://leetcode.com/problems/remove-k-digits
public class Solution {
    public string RemoveKdigits(string num, int k) {
        var digits = num.Length - k;
        var stk = new char[num.Length];
        var top = 0;
        for (var i = 0; i < num.Length; ++i) {
            var c = num[i];
            while (top > 0 && stk[top - 1] > c && k > 0) {
                top -= 1;
                k -= 1;
            }
            stk[top++] = c;
        }
        var idx = 0;
        while (idx < digits && stk[idx] == '0') idx++;
        return idx == digits ? "0" : new String(stk, idx, digits - idx);
    }
}