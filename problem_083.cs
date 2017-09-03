// 83. Remove Duplicates from Sorted List - https://leetcode.com/problems/remove-duplicates-from-sorted-list
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var dummy = new ListNode(0);
        var node = dummy;
        int? prev = null;
        while (head != null) {
            if (prev == null || head.val != prev.Value) {
                node.next = new ListNode(head.val);
                node = node.next;
                prev = head.val;
            } 
            head = head.next;
        }
        return dummy.next;
    }
}