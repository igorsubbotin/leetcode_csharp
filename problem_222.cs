// 222. Count Complete Tree Nodes - https://leetcode.com/problems/count-complete-tree-nodes
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;
        var left = 0;
        var node = root;
        while (node != null) {
            left++;
            node = node.left;
        }
        var right = 0;
        node = root;
        while (node != null) {
            right++;
            node = node.right;
        }
        if (left == right) return (1 << left) - 1;
        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
}