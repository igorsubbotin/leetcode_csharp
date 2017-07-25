// 18. 4Sum - https://leetcode.com/problems/4sum/#
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var result = new List<IList<int>>();
        if (nums.Length < 4) return result;
        Array.Sort(nums);
        var pairs = new List<Pair>();
        var d = new Dictionary<int, IList<Pair>>();
        for (var i = 0; i < nums.Length; i++) {
            for (var j = i + 1; j < nums.Length; j++) {
                var pair = new Pair(nums[i], i, nums[j], j);
                pairs.Add(pair);
                if (!d.ContainsKey(pair.Sum)) d[pair.Sum] = new List<Pair>();
                d[pair.Sum].Add(pair);
            }
        }
        var hs = new HashSet<string>();
        for (var i = 0; i < pairs.Count; i++) {
            var diff = target - pairs[i].Sum;
            if (!d.ContainsKey(diff)) continue;
            foreach (var pair in d[diff]) {
                if (pairs[i].Ix1 == pair.Ix1 || pairs[i].Ix1 == pair.Ix2 || pairs[i].Ix2 == pair.Ix1 || pairs[i].Ix2 == pair.Ix2) continue;
                var list = new List<int> { pairs[i].Value1, pairs[i].Value2, pair.Value1, pair.Value2 };
                list.Sort();
                var key = string.Join(",", list.Select(x => x.ToString()));
                if (hs.Contains(key)) continue;
                hs.Add(key);
                result.Add(list);
            }
        }
        return result;
    }
}

public class Pair {
    public Pair(int value1, int ix1, int value2, int ix2) {
        Value1 = value1;
        Ix1 = ix1;
        Value2 = value2;
        Ix2 = ix2;
        Sum = value1 + value2;
    }
    
    public int Sum { get; set; }
    public int Value1 { get; set; }
    public int Ix1 { get; set; }
    public int Value2 { get; set; }
    public int Ix2 { get; set; }
}