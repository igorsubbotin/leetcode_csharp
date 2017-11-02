// 160. Intersection of Two Linked Lists - https://leetcode.com/problems/intersection-of-two-linked-lists
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var n1 = 0;
        var h1 = headA;
        while (h1 != null) {
            n1++;
            h1 = h1.next;
        }
        
        var n2 = 0;
        var h2 = headB;
        while (h2 != null) {
            n2++;
            h2 = h2.next;
        }
        
        h1 = headA;
        h2 = headB;
        if (n1 > n2) {
            while (n1 > n2) {
                n1--;
                h1 = h1.next;
            } 
        } else {
            while (n2 > n1) {
                n2--;
                h2 = h2.next;
            }
        }
        
        while (h1 != null) {
            if (h1.val == h2.val) return h1;
            h1 = h1.next;
            h2 = h2.next;
        }
        
        return null;
    }
}