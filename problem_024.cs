// 24. Swap Nodes in Pairs - https://leetcode.com/problems/swap-nodes-in-pairs
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        var dummy = new ListNode(0);
        var node = dummy;
        ListNode prev = null;
        while (head != null) {
            if (prev == null) {
                node.next = head;
                prev = head;
                head = head.next;
            } else {
                node.next = head;
                head = head.next;
                node.next.next = prev;
                prev.next = null;
                node = prev;
                prev = null;
            }
        }
        return dummy.next;
    }
}