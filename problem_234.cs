// 234. Palindrome Linked List - https://leetcode.com/problems/palindrome-linked-list
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null || head.next == null) return true;
        var node = head;
        var length = 0;
        while (node != null) {
            length++;
            node = node.next;
        }
        var even = length % 2 == 0;
        node = head;
        var i = 0;
        while (i < length / 2 - 1) {
            node = node.next;
            i++;
        }
        var head2 = node.next;
        if (!even) head2 = head2.next;
        node.next = null;
        head2 = Reverse(head2);
        node = head;
        var node2 = head2;
        while (node != null) {
            if (node.val != node2.val) return false;
            node = node.next;
            node2 = node2.next;
        }
        return true;
    }
    
    private ListNode Reverse(ListNode head) {
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