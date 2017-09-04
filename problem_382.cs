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
    private readonly IList<int> list = new List<int>();
    private readonly Random rnd = new Random();
    
    /** @param head The linked list's head.
        Note that the head is guaranteed to be not null, so it contains at least one node. */
    public Solution(ListNode head) {
        while (head != null) {
            list.Add(head.val);
            head = head.next;
        }
    }
    
    /** Returns a random node's value. */
    public int GetRandom() {
        return list[rnd.Next(list.Count)];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */