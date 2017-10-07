// 669. Trim a Binary Search Tree - https://leetcode.com/problems/trim-a-binary-search-tree
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
    public TreeNode TrimBST(TreeNode root, int L, int R) {
        if (root == null) return null;
        root.left = TrimBST(root.left, L, R);
        root.right = TrimBST(root.right, L, R);
        if (root.val < L) return root.right;
        if (root.val > R) return root.left;
        return root;
    }
}