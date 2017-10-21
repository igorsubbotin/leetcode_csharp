// 575. Distribute Candies - https://leetcode.com/problems/distribute-candies
public class Solution {
    public int DistributeCandies(int[] candies) {
        var hs = new HashSet<int>();
        foreach (var n in candies)
            if (!hs.Contains(n)) hs.Add(n);
        return Math.Min(candies.Length / 2, hs.Count);
    }
}