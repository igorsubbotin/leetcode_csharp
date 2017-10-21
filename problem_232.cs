// 232. Implement Queue using Stacks - https://leetcode.com/problems/implement-queue-using-stacks
public class MyQueue {
    private readonly Stack<int> stack = new Stack<int>();

    /** Initialize your data structure here. */
    public MyQueue() { }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        stack.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        var s = new Stack<int>();
        while (stack.Count > 1) s.Push(stack.Pop());
        var last = stack.Pop();
        while (s.Count > 0) stack.Push(s.Pop());
        return last;
    }
    
    /** Get the front element. */
    public int Peek() {
        var s = new Stack<int>();
        while (stack.Count > 1) s.Push(stack.Pop());
        var last = stack.Pop();
        stack.Push(last);
        while (s.Count > 0) stack.Push(s.Pop());
        return last;
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return stack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */