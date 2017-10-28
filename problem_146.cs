// 146. LRU Cache - https://leetcode.com/problems/lru-cache
public class LRUCache {
    private readonly int capacity;
    private readonly IDictionary<int, Node> nodes = new Dictionary<int, Node>();
    private Node start;
    private Node end;

    public LRUCache(int capacity) {
        this.capacity = capacity;
    }
    
    private int Count {
        get {
            return this.nodes.Count;
        }
    }
    
    public int Get(int key) {
        if (!nodes.ContainsKey(key)) return -1;
        Touch(key);
        return nodes[key].val;
    }
    
    public void Put(int key, int value) {
        if (nodes.ContainsKey(key)) {
            nodes[key].val = value;
            Touch(key);
        } else {
            var node = new Node(key, value);
            if (this.Count == 0) {
                this.start = node;
                this.end = node;
            } else {
                this.end.next = node;
                node.prev = this.end;
                this.end = node;
            }
            this.nodes[key] = node;
            Clean();
        }
    }
    
    private void Touch(int key) {
        if (this.Count < 2) return;
        if (!this.nodes.ContainsKey(key)) return;
        var node = this.nodes[key];
        if (node == this.end) return;
        if (node == this.start) {
            this.start = node.next;
            node.next = null;
            this.end.next = node;
            node.prev = this.end;
            this.end = node;
        } else {
            node.prev.next = node.next;
            node.next.prev = node.prev;
            node.next = null;
            this.end.next = node;
            node.prev = this.end;
            this.end = node;
        }
    }
    private void Clean() {
        if (this.Count <= this.capacity) return;
        this.nodes.Remove(this.start.key);
        this.start = this.start.next;
        if (this.start != null) this.start.prev = null;
    }
}

public class Node {
    public Node prev;
    public Node next;
    public int key;
    public int val;
    public Node(int key, int val) {
        this.key = key;
        this.val = val;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */