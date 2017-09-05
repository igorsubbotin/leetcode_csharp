// 39. Combination Sum - https://leetcode.com/problems/combination-sum
public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Array.Sort(candidates);
        var q = new List<Combination>();
        for (var i = 0; i < candidates.Length; i++) {
            var value = candidates[i];
            if (value > target) continue;
            q.Add(new Combination(i, value, new List<int> { value }));
        }
        var j = 0;
        var result = new List<IList<int>>();
        var hs = new HashSet<string>();
        while (j < q.Count) {
            var item = q[j];
            j++;
            if (item.sum == target) {
                var key = item.GetKey();
                if (!hs.Contains(key)) {
                    hs.Add(key);
                    result.Add(item.nums);
                }
                continue;
            }
            for (var k = item.ix; k < candidates.Length; k++) {
                var value = candidates[k];
                var sum = item.sum + value;
                if (sum > target) break;
                var clone = item.nums.ToList();
                clone.Add(value);
                q.Add(new Combination(k, sum, clone));
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