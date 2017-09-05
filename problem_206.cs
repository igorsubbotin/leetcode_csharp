// 206. Reverse Linked List - https://leetcode.com/problems/reverse-linked-list
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        while (head != null) {
            var next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        return prev;
    }
}