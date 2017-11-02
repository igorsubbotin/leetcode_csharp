// 237. Delete Node in a Linked List - https://leetcode.com/problems/delete-node-in-a-linked-list
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        if (node == null || node.next == null) return;
        while (true) {
            node.val = node.next.val;
            if (node.next.next == null) {
                node.next = null;
                return;
            }
            node = node.next;
        }
    }
}