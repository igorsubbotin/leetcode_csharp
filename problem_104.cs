// 104. Maximum Depth of Binary Tree - https://leetcode.com/problems/maximum-depth-of-binary-tree
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
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;
        var max = 0;
        var s = new Stack<TreeNode>();
        root.val = 1;
        s.Push(root);
        while (s.Count > 0) {
            var node = s.Pop();
            max = Math.Max(max, node.val);
            if (node.left != null) {
                node.left.val = node.val + 1;
                s.Push(node.left);
            }
            if (node.right != null) {
                node.right.val = node.val + 1;
                s.Push(node.right);
            }
        }
        return max;
    }
}