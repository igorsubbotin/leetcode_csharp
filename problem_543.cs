// 543. Diameter of Binary Tree - https://leetcode.com/problems/diameter-of-binary-tree
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
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null) return 0;
        if (root.left == null && root.right == null) {
            root.val = 0;
            return 0;
        }
        var max = Math.Max(DiameterOfBinaryTree(root.left), DiameterOfBinaryTree(root.right));
        var left = 0;
        var max_left = 0;
        if (root.left != null) {
            left = root.left.val;
            max_left = 1 + left;
        }
        var right = 0;
        var max_right = 0;
        if (root.right != null) {
            right = root.right.val;
            max_right = 1 + right;
        }
        root.val = 1 + Math.Max(left, right);
        return Math.Max(max_left + max_right, max);
    }
}