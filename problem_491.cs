// 491. Increasing Subsequences - https://leetcode.com/problems/increasing-subsequences
public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        var list = nums.OrderBy(x => x).ToList();
        var q = new Queue<Node>();
        for (var i = 0; i < list.Count - 1; i++) {
            q.Enqueue(new Node(i + 1, new List<int> { list[i] }));
        }
        var v = new HashSet<string>();
        var result = new List<IList<int>>();
        while (q.Count > 0) {
            var node = q.Dequeue();
            if (node.list.Count >= 2) {
                var key = node.GetKey();
                if (!v.Contains(key)) {
                    v.Add(key);
                    result.Add(node.list);
                }
            }
            if (node.ix == list.Count) continue;
            for (var i = node.ix; i < list.Count; i++) {
                var clone = node.list.ToList();
                clone.Add(list[i]);
                q.Enqueue(new Node(i + 1, clone));
            }
        }
        return result;
    }
    
    private class Node {
        public readonly int ix;
        public readonly IList<int> list;
        public Node(int ix, IList<int> list) {
            this.ix = ix;
            this.list = list;
        }
        public string GetKey() {
            return string.Join(",", list.Select(x => x.ToString()));
        }
    }
}