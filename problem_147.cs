// 147. Insertion Sort List - https://leetcode.com/problems/insertion-sort-list
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode InsertionSortList(ListNode head) {
        if (head == null) return null;
        var sorted = head;
        head = head.next;
        sorted.next = null;
        while (head != null) {
            var next = head.next;
            if (head.val < sorted.val) {
                head.next = sorted;
                sorted = head;
            } else {
                var prev = sorted;
                var node = sorted.next;
                while (node != null) {
                    if (node.val > head.val) break;
                    prev = node;
                    node = node.next;
                }
                head.next = prev.next;
                prev.next = head;
            }
            
            head = next;
        }
        
        return sorted;
    }
}