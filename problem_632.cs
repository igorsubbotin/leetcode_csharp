// 632. Smallest Range - https://leetcode.com/problems/smallest-range
public class Solution {
    public int[] SmallestRange(IList<IList<int>> nums) {
        ListNode start = null;
        ListNode end = null;
        var pq = new PriorityQueue();
        var min = int.MaxValue;
        var min_ix = new [] { -1, -1 };
        for (var i = 0; i < nums.Count; i++) {
            if (nums[i].Count == 0) continue;
            pq.Enqueue(new Item(nums[i][0], i, 0));
        }
        var p = new Dictionary<int, ListNode>();
        while (!pq.IsEmpty) {
            var item = pq.Dequeue();
            if (item.ix + 1 < nums[item.list_ix].Count) {
                pq.Enqueue(new Item(nums[item.list_ix][item.ix + 1], item.list_ix, item.ix + 1));
            }
            var node = new ListNode(nums[item.list_ix][item.ix]);
            if (p.ContainsKey(item.list_ix)) {
                var remove = p[item.list_ix];
                if (remove.prev != null && remove.next != null) {
                    remove.prev.next = remove.next;
                    remove.next.prev = remove.prev;
                } else {
                    if (remove.prev == null) {
                        start = start.next;
                        if (start != null) start.prev = null;
                    }
                    if (remove.next == null) {
                        end = end.prev;
                        if (end != null) end.next = null;
                    }
                }
            }
            if (start == null && end == null) {
                start = node;
                end = node;
            } else {
                end.next = node;
                node.prev = end;
                end = node;
            }
            p[item.list_ix] = node;
            
            if (p.Count == nums.Count) {
                var local_min = end.val - start.val;
                if (local_min < min) {
                    min = local_min;
                    min_ix = new [] { start.val, end.val };
                }
            }
        }
        return min_ix;
    }
}

public class ListNode {
    public readonly int val;
    public ListNode prev;
    public ListNode next;
    public ListNode(int val) {
        this.val = val;
    }
}

public class PriorityQueue {
    private readonly SortedList<int, Queue<Item>> list = new SortedList<int, Queue<Item>>();
    
    public bool IsEmpty { get { return list.Count == 0; } }
    
    public void Enqueue(Item item) {
        if (!list.ContainsKey(item.val)) list.Add(item.val, new Queue<Item>());
        list[item.val].Enqueue(item);
    }
    public Item Dequeue() {
        var queue = list.Values[0];
        var item = queue.Dequeue();
        if (queue.Count == 0) list.RemoveAt(0);
        return item;
    }
}

public class Item {
    public readonly int val;
    public readonly int list_ix;
    public readonly int ix;
    
    public Item(int val, int list_ix, int ix) {
        this.val = val;
        this.list_ix = list_ix;
        this.ix = ix;
    }
}