// 670. Maximum Swap - https://leetcode.com/problems/maximum-swap
public class Solution {
    public int MaximumSwap(int num) {
        var digits = new List<int>();
        foreach (var c in num.ToString()) digits.Add(int.Parse(c.ToString()));
        for (var i = 0; i < digits.Count - 1; i++) {
            var max = 0;
            var max_ix = 0;
            for (var j = i + 1; j < digits.Count; j++) {
                if (digits[j] >= max) {
                    max = digits[j];
                    max_ix = j;
                }            
            }
            if (max > digits[i]) {
                var temp = digits[max_ix];
                digits[max_ix] = digits[i];
                digits[i] = temp;
                return int.Parse(string.Join("", digits));
            }
        }            
        return int.Parse(string.Join("", digits));
    }
}