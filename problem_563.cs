// 563. Binary Tree Tilt - https://leetcode.com/problems/binary-tree-tilt
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
    public int FindTilt(TreeNode root) {
        Sum(root);
        return FindTotalTilt(root);
    }
    
    private static int FindTotalTilt(TreeNode node) {
        if (node == null) return 0;
        return FindNodeTilt(node) + FindTotalTilt(node.left) + FindTotalTilt(node.right);
    }
    
    private static int FindNodeTilt(TreeNode node) {
        if (node == null) return 0;
        var left = 0;
        if (node.left != null) left = node.left.val;
        var right = 0;
        if (node.right != null) right = node.right.val;
        return Math.Abs(left - right);
    }
    private static void Sum(TreeNode node) {
        if (node == null) return;
        if (node.left != null) {
            Sum(node.left);
            node.val += node.left.val;
        }
        if (node.right != null) {
            Sum(node.right);
            node.val += node.right.val;
        }
    }
}