// 138. Copy List with Random Pointer - https://leetcode.com/problems/copy-list-with-random-pointer
/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head) {
        var dummy = new RandomListNode(0);
        var node = head;
        var newnode = dummy;
        var d = new Dictionary<int, RandomListNode>();
        while (node != null) {
            var add = new RandomListNode(node.label);
            d[add.label] = add;
            newnode.next = add;
            newnode = newnode.next;
            node = node.next;
        }
        node = head;
        newnode = dummy.next;
        while (node != null) {
            if (node.random != null) newnode.random = d[node.random.label];
            node = node.next;
            newnode = newnode.next;
        }
        return dummy.next;
    }
}