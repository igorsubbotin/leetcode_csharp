// 142. Linked List Cycle II - https://leetcode.com/problems/linked-list-cycle-ii
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
    public ListNode DetectCycle(ListNode head) {
        if (head == null || head.next == null) return null;
        var first = head;
        var second = head;
        var isCycle = false;
        while(first != null && second != null) {
            first = first.next;
            if (second.next == null) return null;
            second = second.next.next;
            if (first == second) { 
                isCycle = true; 
                break; 
            }
        }
        if (!isCycle) return null;
        first = head;
        while (first != second) {
            first = first.next;
            second = second.next;
        }
        return first;
    }
}