// 258. Add Digits - https://leetcode.com/problems/add-digits
public class Solution {
    public int AddDigits(int num) {
        return 1 + (num - 1) % 9;
    }
}