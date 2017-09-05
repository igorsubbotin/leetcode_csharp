// 40. Combination Sum II - https://leetcode.com/problems/combination-sum-ii
public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        var s = new Stack<Combination>();
        for (var i = 0; i < candidates.Length; i++) {
            var value = candidates[i];
            if (value > target) continue;
            s.Push(new Combination(i, value, new List<int> { value }));
        }
        var result = new List<IList<int>>();
        var hs = new HashSet<string>();
        while (s.Count > 0) {
            var item = s.Pop();
            if (item.sum == target) {
                var key = item.GetKey();
                if (!hs.Contains(key)) {
                    hs.Add(key);
                    result.Add(item.nums);
                }
                continue;    
            }
            for (var j = item.ix + 1; j < candidates.Length; j++) {
                var value = candidates[j];
                var sum = item.sum + value;
                if (sum > target) break;
                var clone = item.nums.ToList();
                clone.Add(value);
                s.Push(new Combination(j, sum, clone));
            }
        }
        return result;
    }
    
    private class Combination {
        public readonly int ix;
        public readonly int sum;
        public readonly IList<int> nums;
        public Combination(int ix, int sum, IList<int> nums) {
            this.ix = ix;
            this.sum = sum;
            this.nums = nums;
        }
        public string GetKey() {
            return string.Join(",", nums.Select(x => x.ToString()));
        }
    }
}