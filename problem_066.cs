// 66. Plus One - https://leetcode.com/problems/plus-one
public class Solution {
    public int[] PlusOne(int[] digits) {
        var shift = 1;
        for (var i = digits.Length - 1; i >= 0; i--) {
            var sum = digits[i] + shift;
            digits[i] = sum % 10;
            shift = sum / 10;
        }
        if (shift > 0) return (new List<int> { shift }).Concat(digits.ToList()).ToArray();
        return digits;
    }
}