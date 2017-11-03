// 230. Kth Smallest Element in a BST - https://leetcode.com/problems/kth-smallest-element-in-a-bst
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
    public int KthSmallest(TreeNode root, int k) {
        return Find(root, ref k).Value;
    }
    
    private static int? Find(TreeNode root, ref int k) {
        if (root == null || k < 1) return null;
        var left = Find(root.left, ref k);
        if (left != null) return left;
        k--;
        if (k == 0) return root.val;
        return Find(root.right, ref k);
    }
}