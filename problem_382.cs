// 382. Linked List Random Node - https://leetcode.com/problems/linked-list-random-node
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    private readonly ListNode head;
    private readonly Random rnd = new Random();
    
    /** @param head The linked list's head.
        Note that the head is guaranteed to be not null, so it contains at least one node. */
    public Solution(ListNode head) {
        this.head = head;
    }
    
    /** Returns a random node's value. */
    public int GetRandom() {
        ListNode result = null;
        var current = head;
        
        for(var i = 1; current != null; i++) {
            if (rnd.Next(i) == 0) {
                result = current;
            }
            current = current.next;
        }
        
        return result.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */