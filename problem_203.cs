// 203. Remove Linked List Elements - https://leetcode.com/problems/remove-linked-list-elements
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null) return null;
        var dummy = new ListNode(-1);
        dummy.next = head;
        var prev = dummy;
        var node = head;
        while (node != null) {
            if (node.val == val) prev.next = node.next;
            else prev = node;
            node = node.next;
        }
        return dummy.next;
    }
}