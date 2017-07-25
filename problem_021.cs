// 21. Merge Two Sorted Lists - https://leetcode.com/problems/merge-two-sorted-lists
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var dummy = new ListNode(0);
        var node = dummy;
        while (l1 != null || l2 != null) {
            if (l2 == null || (l1 != null && l1.val < l2.val)) {
                node.next = l1;
                l1 = l1.next; 
            }
            else {
                node.next = l2;
                l2 = l2.next; 
            }
            node = node.next;
        }
        return dummy.next;
    }
}