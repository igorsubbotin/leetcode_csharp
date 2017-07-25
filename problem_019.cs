// 19. Remove Nth Node From End of List - https://leetcode.com/problems/remove-nth-node-from-end-of-list
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var list = new List<ListNode>();
        while (head != null) {
            list.Add(head);
            head = head.next;
        }
        var ix = list.Count - n;
        if (ix == 0) return list[0].next;
        if (ix + 1 < list.Count) list[ix - 1].next = list[ix + 1];
        else list[ix - 1].next = null;
        return list[0];
    }
}