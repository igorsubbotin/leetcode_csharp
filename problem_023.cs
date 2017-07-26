// 23. Merge k Sorted Lists - https://leetcode.com/problems/merge-k-sorted-lists
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var dummy = new ListNode(0);
        var node = dummy;
        var q = new PriorityQueue();
        for (var i = 0; i < lists.Length; i++) {
            if (lists[i] == null) continue;
            q.Enqueue(new Item(lists[i].val, i));
        }
        while (!q.IsEmpty) {
            var item = q.Dequeue();
            node.next = lists[item.ix];
            node = lists[item.ix];
            lists[item.ix] = lists[item.ix].next;
            if (lists[item.ix] != null) q.Enqueue(new Item(lists[item.ix].val, item.ix));
        }
        return dummy.next;
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
    public readonly int ix;
    
    public Item(int val, int ix) {
        this.val = val;
        this.ix = ix;
    }
}