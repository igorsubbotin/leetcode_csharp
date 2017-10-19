// 659. Split Array into Consecutive Subsequences - https://leetcode.com/problems/split-array-into-consecutive-subsequences
public class Solution {
    public bool IsPossible(int[] nums) {
        if (nums.Length == 0) return false;
        var n = new List<Number> { new Number(nums[0]) };
        var prev = nums[0];
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] == prev) n[n.Count - 1].count++;
            else n.Add(new Number(nums[i]));
            prev = nums[i];
        }
        var list = new List<IList<int>>();
        for (var i = 0; i < n.Count; i++) {
            var k = list.Count - 1;
            for (var j = 0; j < n[i].count; j++) {
                if (k >= 0 && list[k].Last() + 1 == n[i].val) list[k].Add(n[i].val);
                else {
                    list.Add(new List<int> { n[i].val });
                    k = 0;
                }
                k--;
            }
        }
        foreach (var each in list)
            if (each.Count < 3) return false;
        return true;
    }
}

public class Number {
    public int val;
    public int count = 1;
    public Number(int val) {
        this.val = val;
    }
}