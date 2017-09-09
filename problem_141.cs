// 141. Linked List Cycle - https://leetcode.com/problems/linked-list-cycle
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        var first = head;
        if (first == null || first.next == null) return false;
        var second = first.next;
        while (first.val != second.val) {
            if (first == null || second == null || first.next == null || second.next == null || second.next.next == null) return false;
            first = first.next;
            second = second.next.next;
        }
        return true;
    }
}