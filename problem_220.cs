// 220. Contains Duplicate III - https://leetcode.com/problems/contains-duplicate-iii
public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (nums.Length < 2) return false;
        var list = new List<long[]>();
        for (var i = 0; i < nums.Length; i++) list.Add(new long[] { nums[i], i });
        list = list.OrderBy(x => x[0]).ToList();
        var left = 0;
        var right = 1;
        while (left + 1 < list.Count) {
            var diff = Math.Abs(list[left][0] - list[right][0]);
            if (diff > t) left++;
            else {
                for (var i = left; i < right; i++)
                    for (var j = i + 1; j <= right; j++)
                        if (Math.Abs(list[i][1] - list[j][1]) <= k) return true;
                if (++right == list.Count) break;
            }
        }
        return false;
    }
}