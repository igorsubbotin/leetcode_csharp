// 337. House Robber III - https://leetcode.com/problems/house-robber-iii
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
    public int Rob(TreeNode root) {
        if (root == null) return 0;
        var result = Traverse(root);
        return Math.Max(result[0], result[1]);
    }
    
    private static int[] Traverse(TreeNode node) {
        if (node == null) return new [] { 0, 0 };
        var left = Traverse(node.left);
        var right = Traverse(node.right);
        return new [] { node.val + left[1] + right[1], Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]) };
    }
}