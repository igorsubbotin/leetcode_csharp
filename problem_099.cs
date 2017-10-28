// 99. Recover Binary Search Tree - https://leetcode.com/problems/recover-binary-search-tree
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
    public void RecoverTree(TreeNode root) {
        if (root == null) return;
        TreeNode prev = null;
        TreeNode first = null;
        TreeNode second = null;
        Traverse(root, ref prev, ref first, ref second);
        var tmp = first.val;
        first.val = second.val;
        second.val = tmp;
    }
    
    private static void Traverse(TreeNode root, ref TreeNode prev, ref TreeNode first, ref TreeNode second) {
        if (root == null) return;
        Traverse(root.left, ref prev, ref first, ref second);
        if (prev != null) {
            if (prev.val > root.val) {
                if (first == null) first = prev;
                second = root;
            }
        }
        prev = root;
        Traverse(root.right, ref prev, ref first, ref second);
    }
}