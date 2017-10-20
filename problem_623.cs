// 623. Add One Row to Tree - https://leetcode.com/problems/add-one-row-to-tree
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
    public TreeNode AddOneRow(TreeNode root, int v, int d) {
        var dummy = new TreeNode(-1);
        dummy.left = root;
        Traverse(dummy, v, d, 1);
        return dummy.left;
    }
    
    private static void Traverse(TreeNode root, int v, int d, int c) {
        if (root == null) return;
        if (d != c) {
            Traverse(root.left, v, d, c + 1);
            Traverse(root.right, v, d, c + 1);
            return;
        }
        var left = root.left;
        root.left = new TreeNode(v);
        if (left != null) root.left.left = left;
        var right = root.right;
        root.right = new TreeNode(v);
        if (right != null) root.right.right = right;
    }
}