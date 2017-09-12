// 167. Two Sum II - Input array is sorted - https://leetcode.com/problems/two-sum-ii-input-array-is-sorted
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var d = new Dictionary<int, List<int>>();
        for (var i = 0; i < numbers.Length; i++) {
            if (!d.ContainsKey(numbers[i])) d[numbers[i]] = new List<int>();
            d[numbers[i]].Add(i);
        }
        for (var i = 0; i < numbers.Length; i++) {
            var diff = target - numbers[i];
            if (!d.ContainsKey(diff)) continue;
            foreach (var j in d[diff]) {
                if (i == j) continue;
                return new List<int> { i + 1, j + 1 }.OrderBy(x => x).ToArray();
            }
        }
        return new [] { 0, 0 };
    }
}