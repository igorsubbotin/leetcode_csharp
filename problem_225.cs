// 225. Implement Stack using Queues - https://leetcode.com/problems/implement-stack-using-queues
public class MyStack {
    private readonly Queue<int> queue = new Queue<int>();
    
    /** Initialize your data structure here. */
    public MyStack() {}

    /** Push element x onto stack. */
    public void Push(int x) {
        queue.Enqueue(x);
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        var q = new Queue<int>();
        while (queue.Count > 1) q.Enqueue(queue.Dequeue());
        var last = queue.Dequeue();
        while (q.Count > 0) queue.Enqueue(q.Dequeue());
        return last;
    }
    
    /** Get the top element. */
    public int Top() {
        var q = new Queue<int>();
        while (queue.Count > 1) q.Enqueue(queue.Dequeue());
        var last = queue.Dequeue();
        while (q.Count > 0) queue.Enqueue(q.Dequeue());
        queue.Enqueue(last);
        return last;
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return queue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */