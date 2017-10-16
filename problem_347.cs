// 347. Top K Frequent Elements - https://leetcode.com/problems/top-k-frequent-elements
public class Solution {
    public IList<int> TopKFrequent(int[] nums, int k) {
        var d = new Dictionary<int, int>();
        foreach (var n in nums) {
            if (!d.ContainsKey(n)) d[n] = 0;
            d[n]++;
        }
        var heap = new MinHeap();
        foreach (var key in d.Keys) {
            var value = new Value(key, d[key]);
            heap.Add(value);
            if (heap.list.Count > k) heap.RemoveMin();
        }
        return heap.list.OrderByDescending(x => x.count).ThenBy(x => x.val).Select(x => x.val).ToList();
    }
}

public class Value {
    public readonly int val;
    public int count;
    public Value(int val, int count) {
        this.val = val;
        this.count = count;
    }
}

public class MinHeap {
    public readonly IList<Value> list;
    
    public MinHeap(IList<Value> list) {
        this.list = list;
        BuildMinHeap(this.list);
    }
    public MinHeap() {
        this.list = new List<Value>();
    }
    
    public void Add(Value val) {
        Insert(this.list, val);
    }
    public void RemoveMin() {
        var tmp = this.list[0];
        this.list[0] = this.list[this.list.Count - 1];
        this.list[this.list.Count - 1] = tmp;
        this.list.RemoveAt(this.list.Count - 1);
        MinHeapify(this.list, 0);
    }
    
    private static int Parent(int i) {
        return (i - 1) / 2;
    }
    private static int Left(int i) {
        return 2 * i + 1;
    }
    private static int Right(int i) {
        return 2 * i + 2;
    }
    
    private static void Insert(IList<Value> a, Value val) {
        a.Add(new Value(0, int.MaxValue));
        DecreaseKey(a, a.Count - 1, val);
    }
    private static void DecreaseKey(IList<Value> a, int i, Value val) {
        a[i] = val;
        while (i > 0 && a[Parent(i)].count > a[i].count) {
            var tmp = a[i];
            a[i] = a[Parent(i)];
            a[Parent(i)] = tmp;
            i = Parent(i);
        }
    }
    
    private static void MinHeapify(IList<Value> a, int i) {
        int smallest;
        var l = Left(i);
        var r = Right(i);
        if (l < a.Count && a[l].count < a[i].count) smallest = l;
        else smallest = i;
        if (r < a.Count && a[r].count < a[smallest].count) smallest = r;
        if (smallest != i) {
            var tmp = a[i];
            a[i] = a[smallest];
            a[smallest] = tmp;
            MinHeapify(a, smallest);
        }
    }
    private static void BuildMinHeap(IList<Value> a) {
        for (var i = a.Count / 2 - 1; i >= 0; i--)
            MinHeapify(a, i);
    }
}