// Add Two Numbers - https://leetcode.com/problems/add-two-numbers
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var stub = new ListNode(0);
        var l = stub;
        var shift = 0;
        while (l1 != null || l2 != null) {
            var val = shift;
            if (l1 != null) {
                val += l1.val;
                l1 = l1.next;
            } 
            if (l2 != null) {
                val += l2.val;
                l2 = l2.next;
            }
            l.next = new ListNode(val % 10);
            l = l.next;
            shift = val / 10;
        }
        if (shift > 0) l.next = new ListNode(shift);
        return stub.next;
    }
}